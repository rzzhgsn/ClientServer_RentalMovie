using API_RentalMovie.Models;
using API_RentalMovie.ViewModels;
using ClientServer_RentalMovie.Context;
using MCC75_MVC.Handler;
using Microsoft.EntityFrameworkCore;

namespace API_RentalMovie.Repositories.Data;

public class AccountRepository : GeneralRepository<int, Account>
{
    private readonly MyContext context;

    public AccountRepository(MyContext context) : base(context)
    {
        this.context = context;
    }

    public async Task<int> Register(RegisterVM registerVM)
    {
        int result = 0;
        Country country = new Country
        {
            Name = registerVM.CountryName,
            LastUpdate = registerVM.LastUpdate,
        };
        if (await context.Countries.AnyAsync(c => c.Name == country.Name))
        {
            country.Id = context.Countries.FirstOrDefault(c => c.Name == country.Name).Id;
        }
        else
        {
            await context.Countries.AddAsync(country);
            result = await context.SaveChangesAsync();
        }

        City city = new City
        {
            Name = registerVM.CityName,
            LastUpdate = registerVM.LastUpdate,
            CountryId = country.Id
        };
        if (await context.Cities.AnyAsync(c => c.Name == city.Name))
        {
            city.Id = context.Cities.FirstOrDefault(c => c.Name == city.Name).Id;
        }
        else
        {
            await context.Cities.AddAsync(city);
            result = await context.SaveChangesAsync();
        }

        Address address = new Address
        {
            Address1 = registerVM.Address1,
            Address2 = registerVM.Address2,
            District = registerVM.District,
            PostalCode = registerVM.PostalCode,
            Phone = registerVM.Phone,
            LastUpdate = registerVM.LastUpdate,
            CityId = city.Id,
        };
        await context.Addresses.AddAsync(address);
        result = await context.SaveChangesAsync();

        Store store = new Store
        {
            LastUpdate = registerVM.LastUpdate,
            AddressId = address.Id
        };
        await context.Stores.AddAsync(store);
        result = await context.SaveChangesAsync();

        Staff staff = new Staff
        {
            PaymentId = registerVM.PaymentId,
            FirstName = registerVM.FirstName,
            LastName = registerVM.LastName,
            Email = registerVM.Email,
            Active = registerVM.Active,
            Password = registerVM.Password,
            LastUpdate = registerVM.LastUpdate,
            PictureUrl = registerVM.PictureUrl,
            AddressId = address.Id,
            StoreId = store.Id
        };
        await context.Staffs.AddAsync(staff);
        result = await context.SaveChangesAsync();

        Account account = new Account
        {
            StaffId = staff.Id,
            Password = Hashing.HashPassword(registerVM.Password),
        };
        await context.Accounts.AddAsync(account);
        result = await context.SaveChangesAsync();

        AccountRole accountRole = new AccountRole
        {
            AccountId = account.StaffId,
            RoleId = 2
        };
        await context.AccountRoles.AddAsync(accountRole);
        result = await context.SaveChangesAsync();

        return result;
    }
    public async Task<bool> Login(LoginVM loginVM)
    {
        var getAccount = await context.Staffs
            .Include(s => s.Account)
            .Select(s => new LoginVM
            {
                Email = s.Email,
                Password = s.Account.Password
            }).SingleOrDefaultAsync(a => a.Email == loginVM.Email);

        if (getAccount is null)
        {
            return false;
        }

        return Hashing.ValidatePassword(loginVM.Password, getAccount.Password);
    }
    public async Task<UserdataVM> GetUserdata(string email)
    {
        var userdata = await (from s in context.Staffs
                              join a in context.Accounts
                              on s.Id equals a.StaffId
                              join ar in context.AccountRoles
                              on a.StaffId equals ar.AccountId
                              join r in context.Roles
                              on ar.RoleId equals r.Id
                              where s.Email == email
                              select new UserdataVM
                              {
                                  Email = s.Email,
                                  FullName = String.Concat(s.FirstName, " ", s.LastName)
                              }).FirstOrDefaultAsync();

        return userdata;
    }
    public async Task<IEnumerable<string>> GetRolesById(string email)
    {
        var getNIK = await context.Staffs.FirstOrDefaultAsync(s => s.Email == email);
        return await context.AccountRoles.Where(ar => ar.AccountId == getNIK.Id).Join(
            context.Roles,
            ar => ar.RoleId,
            r => r.Id,
            (ar, r) => r.Name).ToListAsync();
    }
}

using Microsoft.AspNetCore.Identity;

namespace UILayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{

		public override IdentityError PasswordTooShort(int length)
		{
			//return base.PasswordTooShort(length);
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakter olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			//return base.PasswordRequiresUpper();
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Parola en az 1 buyuk harf olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			//return base.PasswordRequiresLower();
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Parola en az 1 kucuk harf olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			//return base.PasswordRequiresDigit();
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Parola en az 1 tane rakam olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Lutfen en az 1 tane sembol giriniz"
			};
		}
		

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesTracker.Common.Members;
using ExpensesTracker.Data;

namespace ExpensesTracker.Business
{
    class MemberValidation
    {
        private static readonly List<string> errors;
        public static string ErrorMessage
        {
            get
            {
                string message = "";
                foreach (string line in errors)
                {
                    message += line + "\r\n";
                }
                return message;
            }
        }
        static MemberValidation()
        {
            errors = new List<string>();
        }
        public static Member LoginMember(string user, string pass)
        {
            Member activeMember = null;
            if(Validate(user, pass))
            {
                activeMember = MemberRepository.LoginMember(user, pass);
            }
            return activeMember;
        }

        private static bool Validate(string user, string pass)
        {
            errors.Clear();
            if (string.IsNullOrWhiteSpace(user))
            {
                errors.Add("The User Name cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                errors.Add("The password cannot be empty");
            }
            return !(errors.Count > 0);
        }
    }
}

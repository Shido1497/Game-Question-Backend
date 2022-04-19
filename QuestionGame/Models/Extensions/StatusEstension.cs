using QuestionGame.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionGame.Models.Extensions
{
    public static class StatusEstension
    {
        public static string GetStatusDescription( this Status status) 
        {
            return status.ToString();
        }

        public static Status GetStatus(this string status)
        {
            switch (status)
            {
                case "In Game":
                    return Status.Create;
                case "Retire":
                    return Status.Retire;
                case "Winner":
                    return Status.Winner;
                default:
                    return Status.Lose;
            }
        }
    }
}

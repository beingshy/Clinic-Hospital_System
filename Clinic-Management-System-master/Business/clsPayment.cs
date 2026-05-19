using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using ClinicManagementDB_DataAccess;

namespace ClinicManagementDB_Business
{
    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int? PaymentID { set; get; }
        public decimal Amount { set; get; }
        public byte PaymentMethod { set; get; }
        public DateTime PaymentDate { set; get; }
        public short CreatedByUserID { set; get; }
        public DateTime CreatedAt { set; get; }

        public clsPayment()
        {
            this.PaymentID = null;
            this.Amount = -1;
            this.PaymentMethod = 0;
            this.PaymentDate = DateTime.Now;
            this.CreatedByUserID = -1;
            this.CreatedAt = DateTime.Now;
            Mode = enMode.AddNew;
        }
        private clsPayment(int? PaymentID, decimal Amount, byte PaymentMethod, DateTime PaymentDate, short CreatedByUserID, DateTime CreatedAt)
        {
            this.PaymentID = PaymentID;
            this.Amount = Amount;
            this.PaymentMethod = PaymentMethod;
            this.PaymentDate = PaymentDate;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedAt = CreatedAt;
            Mode = enMode.Update;
        }
        private bool _AddNewPayment()
        {
            this.PaymentID = (int?)clsPaymentData.AddNewPayment(this.Amount, this.PaymentMethod, this.PaymentDate, this.CreatedByUserID, this.CreatedAt);
            return (this.PaymentID != -1);
        }
        public static clsPayment Find(int? PaymentID)
        {
            decimal Amount = -1;
            byte PaymentMethod = 0;
            DateTime PaymentDate = DateTime.Now;
            short CreatedByUserID = -1;
            DateTime CreatedAt = DateTime.Now;

            bool IsFound = clsPaymentData.GetPaymentByID(PaymentID, ref Amount, ref PaymentMethod, ref PaymentDate, ref CreatedByUserID, ref CreatedAt);

            if(IsFound)
                return new clsPayment(PaymentID, Amount, PaymentMethod, PaymentDate, CreatedByUserID, CreatedAt);
            else
                return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPayment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
        public static bool DoesPaymentExist(int? PaymentID)
            => clsPaymentData.DoesPaymentExist(PaymentID);
        public static DataTable GetPayments(short PageNumber, int PageSize, ref int Records)
            => clsPaymentData.GetAllPayments(PageNumber, PageSize, ref Records);
        public static async Task<decimal> GetTotalPaymentsAmountAsync() 
            => await clsPaymentData.GetTotalPaymentsAmountAsync();
        public static async Task<decimal> GetAverageAmountPerPaymentAsync() 
            => await clsPaymentData.GetAverageAmountPerPaymentAsync();
        public static async Task<int> GetTotalPaymentsAsync() 
            => await clsPaymentData.GetTotalPaymentsAsync();
        public static async Task<string> GetMostUsedPaymentMethodAsync() 
            => await clsPaymentData.GetMostUsedPaymentMethodAsync();
    }
}

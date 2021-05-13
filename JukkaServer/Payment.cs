// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Newtonsoft.Json;

namespace JukkaServer
{
    public class Payment
    {
        public string MachineId { get; set; }
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public string InvoiceNumber { get; set; }
        public string TransactionId { get; set; }
        public decimal ApprovedAmount { get; set; }
        public int ApprovalCode { get; set; }
        public string MaskedCardNumber { get; set; }
        public string CardType { get; set; }
        public string NameOnCard { get; set; }
        public string IssuerName { get; set; }
        public int ExpiryDate { get; set; }
        public string EntryMode { get; set; }
        public int ErrorCode { get; set; }
        public string Message { get; set; }

        Payment()
        {
        }

        Payment(string machineId, int orderId, int storeId, string invoiceNumber,
            string transactionId, decimal approvedAmount, string maskedCardNumber,
            string cardType, string nameOnCard, string issuerName, int expiryDate,
            string entryMode, int errorCode, string message)
        {
            MachineId = machineId;
            OrderId = orderId;
            StoreId = storeId;
            InvoiceNumber = invoiceNumber;
            TransactionId = transactionId;
            ApprovedAmount = approvedAmount;
            ApprovalCode = ApprovalCode;
            MaskedCardNumber = maskedCardNumber;
            CardType = cardType;
            NameOnCard = nameOnCard;
            IssuerName = issuerName;
            ExpiryDate = expiryDate;
            EntryMode = entryMode;
            ErrorCode = errorCode;
            Message = message;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}

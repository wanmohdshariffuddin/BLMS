﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BLMS.Models.License
{
    public class LicenseSite
    {
        [Key]
        public int LicenseID { get; set; }

        //Category
        public int CategoryID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("License Type")]
        public string CategoryName { get; set; }

        //License Details
        [Column(TypeName = "nvarchar(350)")]
        [DisplayName("License Name")]
        public string LicenseName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Registration No")]
        public string RegistrationNo { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Serial No")]
        public string SerialNo { get; set; }

        //Business Div
        public int DivID { get; set; }


        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Business Division")]
        public string DivName { get; set; }

        //Business Unit
        public int UnitID { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Business Unit")]
        public string UnitName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Issued Date")]
        public string IssuedDT { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Expired Date")]
        public string ExpiredDT { get; set; }

        //PIC 1
        [Column(TypeName = "nvarchar(250)")]
        public string PIC1StaffNo { get; set; }

        [Column(TypeName = "nvarchar(350)")]
        [DisplayName("PIC 1 Name")]
        public string PIC1Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("PIC 1 Email")]
        public string PIC1Email { get; set; }

        //PIC 2
        [Column(TypeName = "nvarchar(250)")]
        public string PIC2StaffNo { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("PIC 2 Name (Optional)")]
        public string PIC2Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("PIC 2 Email")]
        public string PIC2Email { get; set; }

        //PIC 3
        [Column(TypeName = "nvarchar(250)")]
        public string PIC3StaffNo { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("PIC 3 Name (Optional)")]
        public string PIC3Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("PIC 3 Email")]
        public string PIC3Email { get; set; }

        [Column(TypeName = "nvarchar(350)")]
        [DisplayName("Remarks")]
        public string Remarks { get; set; }

        //Flag
        public bool isRegistered { get; set; }

        public bool isRenewed { get; set; }

        //License File
        [Key]
        public int LicenseFileId { get; set; }

        public string LicenseFileName { get; set; }

        public string FileType { get; set; }

        public string Extension { get; set; }

        public byte[] Data { get; set; }

        //Renew Remainder
        public DateTime RenewReminderDT { get; set; }

        //Renewal
        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("Registration No")]
        public string RenewalRegistrationNo { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("Serial No")]
        public string RenewalSerialNo { get; set; }

        [DisplayName("Issued Date")]
        public string RenewalIssuedDT { get; set; }

        [DisplayName("Expired Date")]
        public string RenewalExpiredDT { get; set; }

        [Key]
        public int RenewalLicenseFileId { get; set; }

        public string RenewalLicenseFileName { get; set; }

        public string RenewalFileType { get; set; }

        public string RenewalExtension { get; set; }

        public byte[] RenewalData { get; set; }

        //check linked data
        public int ExistData { get; set; }

        //check license had file
        public bool hasFile { get; set; }

        public string UserName { get; set; }
        public string UserNameStaffNo { get; set; }
    }
}

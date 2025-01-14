﻿using BLMS.Models.License;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BLMS.Context
{
    public class ddlLicenseDBContext
    {
        readonly string connectionstring = "Data Source = 10.249.1.125; Database=BLMSDev;User ID = Appsa; Password=Opuswebsql2017;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region LICENSE SITE
        #region ddlCategory
        public IEnumerable<LicenseSite> ddlCategoryLicenseSite()
        {
            var categoryLicenseSiteList = new List<LicenseSite>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var categoryLicenseSite = new LicenseSite();

                    categoryLicenseSite.CategoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                    categoryLicenseSite.CategoryName = dr["CategoryName"].ToString();

                    categoryLicenseSiteList.Add(categoryLicenseSite);
                }

                conn.Close();
            }

            return categoryLicenseSiteList;
        }
        #endregion

        #region ddlBusinessDiv
        public IEnumerable<LicenseSite> ddlBusinessDivLicenseSite()
        {
            var businessDivLicenseSiteList = new List<LicenseSite>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessDiv", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var businessDivLicenseSite = new LicenseSite();

                    businessDivLicenseSite.DivID = Convert.ToInt32(dr["DivID"].ToString());
                    businessDivLicenseSite.DivName = dr["DivName"].ToString();

                    businessDivLicenseSiteList.Add(businessDivLicenseSite);
                }

                conn.Close();
            }

            return businessDivLicenseSiteList;
        }
        #endregion

        #region ddlBusinessUnit
        public IEnumerable<LicenseSite> ddlBusinessUnitLicenseSite()
        {
            var businessUnitLicenseSiteList = new List<LicenseSite>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessUnit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var businessUnitLicenseSite = new LicenseSite();

                    businessUnitLicenseSite.UnitID = Convert.ToInt32(dr["UnitID"].ToString());
                    businessUnitLicenseSite.UnitName = dr["UnitName"].ToString();

                    businessUnitLicenseSiteList.Add(businessUnitLicenseSite);
                }

                conn.Close();
            }

            return businessUnitLicenseSiteList;
        }
        #endregion

        #region ddlPIC2 
        public IEnumerable<LicenseSite> ddlPIC2LicenseSite()
        {
            var pic2LicenseSiteList = new List<LicenseSite>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLStaffSite", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var pic2LicenseSite = new LicenseSite();

                    pic2LicenseSite.PIC2StaffNo = dr["empl_no"].ToString();
                    pic2LicenseSite.PIC2Name = dr["staff_name"].ToString();

                    pic2LicenseSiteList.Add(pic2LicenseSite);
                }

                conn.Close();
            }

            return pic2LicenseSiteList;
        }
        #endregion

        #region ddlPIC3
        public IEnumerable<LicenseSite> ddlPIC3LicenseSite()
        {
            var pic3LicenseSiteList = new List<LicenseSite>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLStaffSite", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var pic3LicenseSite = new LicenseSite();

                    pic3LicenseSite.PIC3StaffNo = dr["empl_no"].ToString();
                    pic3LicenseSite.PIC3Name = dr["staff_name"].ToString();

                    pic3LicenseSiteList.Add(pic3LicenseSite);
                }

                conn.Close();
            }

            return pic3LicenseSiteList;
        }
        #endregion

        #region ddlBusinessUnitLinkedDivSite
        public DataSet ddlBusinessUnitLinkedDivSite(int DivID)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessUnitLinkedDiv", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DivID", DivID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
        #endregion
        #endregion

        #region LICENSE HQ
        #region ddlCategory
        public IEnumerable<LicenseHQ> ddlCategoryLicenseHQ()
        {
            var categoryLicenseHQList = new List<LicenseHQ>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLCategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var categoryLicenseHQ = new LicenseHQ();

                    categoryLicenseHQ.CategoryID = Convert.ToInt32(dr["CategoryID"].ToString());
                    categoryLicenseHQ.CategoryName = dr["CategoryName"].ToString();

                    categoryLicenseHQList.Add(categoryLicenseHQ);
                }

                conn.Close();
            }

            return categoryLicenseHQList;
        }
        #endregion

        #region ddlBusinessDiv
        public IEnumerable<LicenseHQ> ddlBusinessDivLicenseHQ()
        {
            var businessDivLicenseHQList = new List<LicenseHQ>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessDiv", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var businessDivLicenseHQ = new LicenseHQ();

                    businessDivLicenseHQ.DivID = Convert.ToInt32(dr["DivID"].ToString());
                    businessDivLicenseHQ.DivName = dr["DivName"].ToString();

                    businessDivLicenseHQList.Add(businessDivLicenseHQ);
                }

                conn.Close();
            }

            return businessDivLicenseHQList;
        }
        #endregion

        #region ddlBusinessUnit
        public IEnumerable<LicenseHQ> ddlBusinessUnitLicenseHQ()
        {
            var businessUnitLicenseHQList = new List<LicenseHQ>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessUnit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var businessUnitLicenseHQ = new LicenseHQ();

                    businessUnitLicenseHQ.UnitID = Convert.ToInt32(dr["UnitID"].ToString());
                    businessUnitLicenseHQ.UnitName = dr["UnitName"].ToString();

                    businessUnitLicenseHQList.Add(businessUnitLicenseHQ);
                }

                conn.Close();
            }

            return businessUnitLicenseHQList;
        }
        #endregion

        #region ddlPIC2
        public IEnumerable<LicenseHQ> ddlPIC2LicenseHQ()
        {
            var pic2LicenseHQList = new List<LicenseHQ>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLStaffHQ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var pic2LicenseHQ = new LicenseHQ();

                    pic2LicenseHQ.PIC2StaffNo = dr["empl_no"].ToString();
                    pic2LicenseHQ.PIC2Name = dr["staff_name"].ToString();

                    pic2LicenseHQList.Add(pic2LicenseHQ);
                }

                conn.Close();
            }

            return pic2LicenseHQList;
        }
        #endregion

        #region ddlPIC3 For LicenseHQ
        public IEnumerable<LicenseHQ> ddlPIC3LicenseHQ()
        {
            var pic3LicenseHQList = new List<LicenseHQ>();

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLStaffHQ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var pic3LicenseHQ = new LicenseHQ();

                    pic3LicenseHQ.PIC3StaffNo = dr["empl_no"].ToString();
                    pic3LicenseHQ.PIC3Name = dr["staff_name"].ToString();

                    pic3LicenseHQList.Add(pic3LicenseHQ);
                }

                conn.Close();
            }

            return pic3LicenseHQList;
        }
        #endregion

        #region ddlBusinessUnitLinkedDivHQ For LicenseHQ
        public DataSet ddlBusinessUnitLinkedDivHQ(int DivID)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("spDDLBusinessUnitLinkedDiv", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DivID", DivID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }
        #endregion
        #endregion
    }
}

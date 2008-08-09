using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class UserEntry
    {
        #region Fields

        private int _userID = 0;

        #region UserBasicInfo Fields
        private string _userName = string.Empty;
        private string _password = string.Empty;
        private string _findPassQus = string.Empty;
        private string _findPassAsw = string.Empty;
        private string _activatedIDS = string.Empty;
        private string _email = string.Empty;
        private int _integral = 0;
        private int _userRoleID = 0;
        private string _userRoleName = string.Empty;
        #endregion

        #region UserPersonalInfo Fields
        private int _sex = 0;
        private string _birthday = string.Empty;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _name = string.Empty;
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _postalCode = string.Empty;
        private string _vocational = string.Empty;
        private string _location = string.Empty;
        private string _interest = string.Empty;
        #endregion

        #region UserContactInfo Fields

        private string _liveCity = string.Empty;
        private string _homeAddr = string.Empty;
        private string _homeTel1 = string.Empty;
        private string _homeTel2 = string.Empty;
        private string _mobile = string.Empty;
        private string _liveFax = string.Empty;
        private string _personalEmail = string.Empty;
        private string _personalMessageAddr = string.Empty;
        private string _msn = string.Empty;
        private string _qq = string.Empty;

        #endregion

        #region UserBusinessInfo
        private string _duty = string.Empty;
        private string _company = string.Empty;
        private string _companyCountry = string.Empty;
        private string _companyCity = string.Empty;
        private string _officeCity = string.Empty;
        private string _officeAddr = string.Empty;
        private string _officeTel1 = string.Empty;
        private string _officeTel2 = string.Empty;
        private string _officeFax = string.Empty;
        private string _workEmail = string.Empty;
        private string _workMessageAddr = string.Empty;
        private string _beginWork = string.Empty;
        private string _monthlyIncome = string.Empty;
        #endregion

        #region
        #endregion

        #endregion

        #region Properties

        public int UserID
        {
            set { this._userID = value; }
            get { return this._userID; }
        }

        #region UserBasicInfo Properties

        public string UserName
        {
            set { this._userName = value; }
            get { return this._userName; }
        }

        public string Password
        {
            set { this._password = value; }
            get { return this._password; }
        }

        public string FindPassQus
        {
            set { this._findPassQus = value; }
            get { return this._findPassQus; }
        }

        public string FindPassAsw
        {
            set { this._findPassAsw = value; }
            get { return this._findPassAsw; }
        }

        public string ActivatedIDS
        {
            set { this._activatedIDS = value; }
            get { return this._activatedIDS; }
        }

        public string Email
        {
            set { this._email = value; }
            get { return this._email; }
        }

        public int Integral
        {
            set { this._integral = value; }
            get { return this._integral; }
        }

        public int UserRoleID
        {
            set { this._userRoleID = value; }
            get { return this._userRoleID; }
        }

        public string UserRoleName
        {
            set { this._userRoleName = value; }
            get { return this._userRoleName; }
        }
        #endregion

        #region UserPersonalInfo Properties
       
        public int Sex
        {
            set { this._sex = value; }
            get { return this._sex; }
        }

        public string Birthday
        {
            set { this._birthday = value; }
            get { return this._birthday; }
        }

        public string FirstName
        {
            set { this._firstName = value; }
            get { return this._firstName; }
        }

        public string LastName
        {
            set { this._lastName = value; }
            get { return this._lastName; }
        }

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }

        public string Country
        {
            set { this._country = value; }
            get { return this._country; }
        }

        public string City
        {
            set { this._city = value; }
            get { return this._city; }
        }

        public string PostalCode
        {
            set { this._postalCode = value; }
            get { return this._postalCode; }
        }

        public string Vocational
        {
            set { this._vocational = value; }
            get { return this._vocational; }
        }

        public string Location
        {
            set { this._location = value; }
            get { return this._location; }
        }

        public string Interest
        {
            set { this._interest = value; }
            get { return this._interest; }
        }

        #endregion

        #region UserContactInfo Properties
        public string LiveCity
        {
            set{this._liveCity = value;}
            get{return this._liveCity ;}
        }
        public string HomeAddr
        {
            set{this._homeAddr = value;}
            get{return this._homeAddr ;}
        }
        public string HomeTel1
        {
            set{this._homeTel1 = value;}
            get{return this._homeTel1 ;}
        }
        public string HomeTel2
        {
            set{this._homeTel2 = value;}
            get{return this._homeTel2 ;}
        }
        public string Mobile
        {
            set{this._mobile = value;}
            get{return this._mobile ;}
        }
        public string LiveFax
        {
            set{this._liveFax = value;}
            get{return this._liveFax ;}
        }
        public string PersonalEmail
        {
            set{this._personalEmail = value;}
            get{return this._personalEmail ;}
        }
        public string PersonalMessageAddr
        {
            set{this._personalMessageAddr = value;}
            get{return this._personalMessageAddr ;}
        }
        public string MSN
        {
            set{this._msn = value;}
            get{return this._msn ;}
        }
        public string QQ
        {
            set{this._qq = value;}
            get{return this._qq ;}
        }
        #endregion

        #region UserBusinessInfo Properties

        public string Duty
        {
            set { this._duty = value; }
            get { return this._duty; }
        }
        public string Company
        {
            set { this._company = value; }
            get { return this._company; }
        }
        public string CompanyCountry
        {
            set { this._companyCountry = value; }
            get { return this._companyCountry; }
        }
        public string CompanyCity
        {
            set { this._companyCity = value; }
            get { return this._companyCity; }
        }
        public string OfficeCity
        {
            set { this._officeCity = value; }
            get { return this._officeCity; }
        }
        public string OfficeAddr
        {
            set { this._officeAddr = value; }
            get { return this._officeAddr; }
        }
        public string OfficeTel1
        {
            set { this._officeTel1 = value; }
            get { return this._officeTel1; }
        }
        public string OfficeTel2
        {
            set { this._officeTel2 = value; }
            get { return this._officeTel2; }
        }
        public string OfficeFax
        {
            set { this._officeFax = value; }
            get { return this._officeFax; }
        }
        public string WorkEmail
        {
            set { this._workEmail = value; }
            get { return this._workEmail; }
        }
        public string WorkMessageAddr
        {
            set { this._workMessageAddr = value; }
            get { return this._workMessageAddr; }
        }
        public string BeginWork
        {
            set { this._beginWork = value; }
            get { return this._beginWork; }
        }
        public string MonthlyIncome
        {
            set { this._monthlyIncome = value; }
            get { return this._monthlyIncome; }
        }


        #endregion

        #endregion

        #region Methods
        #endregion
    }
    public class UserRole : NameBase
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion
    }
}

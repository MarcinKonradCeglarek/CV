namespace CV.Models
{
    using System;

    public class Employer
    {
        #region Public Properties

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        public string Position { get; set; }

        public string[] Projects { get; set; }

        public string Company { get; set; }

        public DateTime StartDate { get; set; }

        public string[] Tools { get; set; }

        #endregion
    }
}
namespace CV.Models
{
    using System;

    public class Employer
    {
        #region Public Properties

        public DateTime EndDate { get; set; }

        public string JobDescription { get; set; }

        public string JobTitle { get; set; }

        public string[] JobsDescription { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public string[] Tools { get; set; }

        #endregion
    }
}
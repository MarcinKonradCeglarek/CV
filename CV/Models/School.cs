namespace CV.Models
{
    using System;

    public class School
    {
        #region Public Properties

        public Degree Degree { get; set; }

        public string Department { get; set; }

        public DateTime GraduationDate { get; set; }

        public string Name { get; set; }

        #endregion
    }
}
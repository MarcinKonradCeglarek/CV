namespace CV.Models
{
    #region

    using System.Collections.Generic;

    using Skill = System.String;

    #endregion

    public abstract class Developer
    {
        #region Public Methods and Operators

        public abstract IList<School> Education();

        public abstract IDictionary<string, Level> Skills();

        public abstract IList<Employer> WorkExperience();

        #endregion
    }
}
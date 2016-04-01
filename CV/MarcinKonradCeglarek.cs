namespace CV
{
    using System;
    using System.Collections.Generic;

    using CV.Models;

    using Skill = System.String;

    public class MarcinKonradCeglarek : Developer
    {
        public static readonly string[] ContactInformation = { "marcin.ceglarek@gmail.com" };

        public override IDictionary<Skill, Level> Skills()
        {                                                                                    ////                                 ````
            return new Dictionary<Skill, Level>                                              ////                       ``/syys++yhdmdddhys+-`
                       {                                                                     ////                   `-+ydmNNNNNNNNNMMMMMMMMMMNho:`
                           // C# related skills                                              ////                  :hmNNNMMMMMMMMMMMMMMMMMMMMMMMMNs-
                           { "C#", Level.Great },                                            ////                :yNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd/              
                           { "ASP.NET", Level.Good },                                        ////              -sNMMMMMMMMMMMMMMMMNNMMMMMMMMMMMMMMMMMMh.            
                           { "Razor", Level.Good },                                          ////            `+mMMMMMMMMNmmNNMMMMNMNNMMMMMMMMMMMMMMMMMMN/           
                           { "Entity Framework", Level.Moderate },                           ////            oNMMMMMMNdyyyhmNMMMMMMMMMNNMMMMMMMMMMMMMMMMN:          
                                                                                             ////           `dMMMMMMdso+++oymmNNNNNNNNNNMMMMMMMMMMMMMMMMMm`         
                           // C# tools                                                       ////           .NMMNNNh+//:::/+oooyhdhhhhddmmmmmmNNMMMMMMMMMMy         
                           { "Visual studio", Level.Good },                                  ////           oMMMMNy+//::::-:://:::/+++//////++osyhmMMMMMMMN/        
                           { "Resharper", Level.Good },                                      ////          .NMMMMho///:::-----:::::::::::::://///+sdMMMMMMMm`       
                           { "StyleCop", Level.Good },                                       ////          /MMMMNs+//:::---------------:::::://///odNMMMMMMM-       
                                                                                             ////          +MMMMmo+/::::--------------:::::::////+smNMMMMMMMo       
                           // Other languages                                                ////          +NMMMdo+/:::::------------::::://////+ohNMMMMMMMMs       
                           { "JavaScript", Level.Moderate },                                 ////          .yNMMho//::::-------------:::::////++++smMMMMMMMM+       
                           { "AngularJs", Level.Basic },                                     ////           `/NMhyyoo+++/::-------:::::::///+/+oooohMMMMMMMh`       
                           { "Ember", Level.Basic },                                         ////             +Nddhhhhhdhho+:::::/+syyyhhhyhhhhysoohMMMMMMd.        
                                                                                             ////             .mooshhhhmmhso/:::/oyhhhmmddhhysyysoosNMMMMm-         
                           // Team management tools                                          ////            ``/+//+++++/////:-:/+++///so+sso++/+++odMMMmo```       
                           { "Git", Level.Great },                                           ////           ````+//::///:::/:::////::://////::///+oohmmmy:```       
                           { "Slack", Level.Good },                                          ////         ``````+//::::::://:::////::::--::::::/+oooyhhso`````      
                           { "Jira", Level.Good },                                           ////       ````````++/:::::://::://///:::-----::://+ossyyso.```````    
                                                                                             ////      `````````++/:::::/oo/::/+o+o/:----::::/+++ossyy+.````````    
                           // Social skills                                                  ////    ```````````/o+///////++osyyo++::::::::://+++ossss.``````````   
                           { "English", Level.Good },                                        //// ``````````````-s++++o++//:::::::///////:::/++oossso:````````````  
                           { "Teamwork", Level.Good },                                       //// ```````````````+s+///++ooo++++++ooso+//://+oossyssy/````````````` 
                           { "Leadership", Level.Moderate },                                 //// ```````````````.+so+////+o++++++++/:::///+oosyyyyymNy+.`````````` 
                       };                                                                    //// `````````````````:sso+/////+++//:::::///+osyyhhhydMMMMMh+.``````` 
        }                                                                                    //// ````````````````.-/yhs+/:::::::::::://+oyyhdmdhydMMMMMMMMNy:````` 
                                                                                             //// ``````````./oydmNMMMMNho//:::::::///oshdmmmddhdNMMMMMMMMMMMMd/``` 
        public override IList<Employer> WorkExperience()                                     //// ```````:smMMMMMMMMMMMMMNyo+++++oosyhmmmmmdddmNMMMMMMMMMMMMMMMMm+` 
        {                                                                                    //// `````/mMMMMMMMMMMMMMMMMMMmdmmmmNNNNmmmdddmNMMMMMMMMMMMMMMMMMMMMMN 
            return new List<Employer>                                                        //// ```-dMMMMMMMMMMMMMMMMMMMMNdddddmmmmmmmNMMMMMMMMMMMMMMMMMMMMMMMMMM 
                       {                                                                     //// ``.dMMMMMMMMMMMMMMMMMMMMMMMmhhhdmmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM 
                           new Employer
                               {
                                   StartDate = new DateTime(2015, 02, 02),                   EndDate = DateTime.Now,                          
                                   Company = "Intel Technology Poland",                                                             
                                   Position = "Software Validation Test Enginner",                                               
                                   Description = "Development of testing frameworks and automated tests for RSA project",     
                                   Tools = new[] { "C#" }                                                                        
                               },                                                                                                
                            new Employer                                                                                      
                                {                                                                                                
                                    StartDate = new DateTime(2014, 04, 22),                  EndDate = new DateTime(2015, 02, 28),             
                                    Company = "Self-employed",
                                    Position = "C# .NET Developer",
                                    Projects = new[] { "MVC .NET based loyalty system", "MVC .NET based customer support application", "POC Ember based matchmaking web application" }, 
                                    Tools = new[] { ".NET", "MVC", "Entity Framework", "Ember" }
                                }, 
                            new Employer
                                {
                                    StartDate = new DateTime(2013, 07, 01),                  EndDate = new DateTime(2014, 05, 31),
                                    Company = "Intel Technology Poland (outsourced by SII sp. z o.o.)",
                                    Position = "Software Engineer",
                                    Description = "Development of Command Center - distributed testing platform based on MVC .NET technology and WCF web services.",
                                    Tools = new[] { ".NET", "MVC", "Entity Framework", "Razor", "Kendo" }
                                },
                            new Employer
                                {
                                    StartDate = new DateTime(2012, 01, 01),                  EndDate = new DateTime(2013, 06, 30),
                                    Company = "Gemalto (outsourced by SII sp. z o.o)", 
                                    Position = "Software Engineer",
                                    Description = "Automation of creation and validation process for smartcards"
                                },
                            new Employer
                                {
                                    StartDate = new DateTime(2011, 01, 01),                  EndDate = new DateTime(2011, 12, 31),
                                    Company = "Gdańsk University of Technology, IT Service Center (CUI)",
                                    Position = "Webmaster",
                                    Description = "Development of web applications for internal use"
                                }
                       };
        }

        public override IList<School> Education()
        {
            return new List<School>
                       {
                           new School
                               {
                                   GraduationDate = new DateTime(2011, 09, 28),
                                   Name = "Gdańsk’s University of Technology",
                                   Degree = Degree.Masters,
                                   Department = "Department of Intelligent Interactive Systems"
                               }
                       };
        }
    }
}

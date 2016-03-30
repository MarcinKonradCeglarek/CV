namespace CV
{
    using System;
    using System.Collections.Generic;

    using CV.Enums;
    using CV.Models;

    using Skill = System.String;

    public class MarcinKonradCeglarek : Developer
    {
        public static readonly string[] ContactInformation = { "marcin.ceglarek@gmail.com" };

        public override IDictionary<Skill, Level> Skills()                                   ////
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
        public List<Employer> WorkExperience()                                               //// ```````:smMMMMMMMMMMMMMNyo+++++oosyhmmmmmdddmNMMMMMMMMMMMMMMMMm+` 
        {                                                                                    //// `````/mMMMMMMMMMMMMMMMMMMmdmmmmNNNNmmmdddmNMMMMMMMMMMMMMMMMMMMMMN 
            return new List<Employer>                                                        //// ```-dMMMMMMMMMMMMMMMMMMMMNdddddmmmmmmmNMMMMMMMMMMMMMMMMMMMMMMMMMM 
                       {                                                                     //// ``.dMMMMMMMMMMMMMMMMMMMMMMMmhhhdmmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM 
                           new Employer
                               {
                                   StartDate = new DateTime(2015, 2, 2),        EndDate = DateTime.Now,                          
                                   Name = "Intel Technology Poland",                                                             
                                   JobTitle = "Software Validation Test Enginner",                                               
                                   JobDescription = "Development of testing frameworks and automated tests for RSA project",     
                                   Tools = new[] { "C#" }                                                                        
                               },                                                                                                
                            new Employer()                                                                                       
                                {                                                                                                
                                    StartDate = new DateTime(2014, 4, 22),      EndDate = new DateTime(2015, 2, 28),             
                                    Name = "Self-employed",
                                    JobTitle = "C# .NET Developer",
                                    JobsDescription = new[] { "MVC .NET based loyalty system", "MVC .NET based customer support application", "POC Ember based matchmaking web application" }
                                }, 
                            new Employer
                                {
                                    StartDate = new DateTime(2013, 7, 1),       EndDate = new DateTime(2014, 5, 31),
                                    Name = "Intel Technology Poland (outsourced by SII sp. z o.o.)",
                                    JobTitle = "Software Engineer",
                                    JobDescription = "Development of Command Center - distributed testing platform based on MVC .NET technology and WCF web services.",
                                    Tools = new[] { ".NET", "MVC", "Razor", "Kendo" }
                                },
                            new Employer
                                {
                                    StartDate = new DateTime(2012, 1, 1),       EndDate = new DateTime(2013, 6, 30),
                                    Name = "Gemalto (outsourced by SII sp. z o.o)", 
                                    JobTitle = "Software Engineer",
                                    JobDescription = "Automation of creation and validation process for smartcards"
                                },
                            new Employer
                                {
                                    StartDate = new DateTime(2011, 01, 01),     EndDate = new DateTime(2011, 12, 31),
                                    Name = "Gdańsk University of Technology, IT Service Center (CUI)",
                                    JobTitle = "Webmaster",
                                    JobDescription = "Development of web applications for internal use"
                                }
                       };
        }

        public List<School> Education()
        {
            return new List<School>
                       {
                           new School
                               {
                                   GraduationDate = new DateTime(2011),
                                   Name = "Gdańsk’s University of Technology",
                                   Degree = Degree.Masters,
                                   Department = "Department of Intelligent Interactive Systems"
                               }
                       };
        }
    }
}



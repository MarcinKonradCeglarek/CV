// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MarcinKonradCeglarek.cs">
//   Copyright (c) 2012 All Rights Reserved
// </copyright>
// <legal>
//   I hereby give consent for my personal data to be processed for the purposes of recruitment, in accordance 
//   with the Personal Data Protection Act dated 29.08.1997 (uniform text: Journal of Laws of the Republic of 
//   Poland 2002 No 101, item 926 with further amendments)
// </legal>
// --------------------------------------------------------------------------------------------------------------------
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
                           // C# skills                                                      ////                  :hmNNNMMMMMMMMMMMMMMMMMMMMMMMMNs-
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
                           // Associated soft skills                                         ////            ``/+//+++++/////:-:/+++///so+sso++/+++odMMMmo```       
                           { "Sociability", Level.Great },                                   ////           ````+//::///:::/:::////::://////::///+oohmmmy:```       
                           { "English", Level.Good },                                        ////         ``````+//::::::://:::////::::--::::::/+oooyhhso`````      
                           { "User-experience", Level.Moderate },                            ////       ````````++/:::::://::://///:::-----::://+ossyyso.```````    
                                                                                             ////      `````````++/:::::/oo/::/+o+o/:----::::/+++ossyy+.````````    
                           // Code management tools                                          ////    ```````````/o+///////++osyyo++::::::::://+++ossss.``````````   
                           { "Git", Level.Great },                                           //// ``````````````-s++++o++//:::::::///////:::/++oossso:````````````  
                           { "Slack", Level.Good },                                          //// ```````````````+s+///++ooo++++++ooso+//://+oossyssy/````````````` 
                           { "Jira", Level.Good },                                           //// ```````````````.+so+////+o++++++++/:::///+oosyyyyymNy+.`````````` 
                                                                                             //// `````````````````:sso+/////+++//:::::///+osyyhhhydMMMMMh+.``````` 
                           // Other skills                                                   //// ````````````````.-/yhs+/:::::::::::://+oyyhdmdhydMMMMMMMMNy:`````               
                           { "Teamwork", Level.Good },                                       //// ``````````./oydmNMMMMNho//:::::::///oshdmmmddhdNMMMMMMMMMMMMd/``` 
                           { "Leadership", Level.Moderate },                                 //// ```````:smMMMMMMMMMMMMMNyo+++++oosyhmmmmmdddmNMMMMMMMMMMMMMMMMm+` 
                       };                                                                    //// `````/mMMMMMMMMMMMMMMMMMMmdmmmmNNNNmmmdddmNMMMMMMMMMMMMMMMMMMMMMN 
        }                                                                                    //// ```-dMMMMMMMMMMMMMMMMMMMMNdddddmmmmmmmNMMMMMMMMMMMMMMMMMMMMMMMMMM 
                                                                                             //// ``.dMMMMMMMMMMMMMMMMMMMMMMMmhhhdmmNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM 
        public override IList<Employer> WorkExperience()                                     
        {                                                                                    
            return new List<Employer>                                                        
                       {                                                                     
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

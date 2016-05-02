using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopGunSyllabus.Core.Model;

namespace TopGunSyllabus.Core.Repository
{
    public class PhaseRepository
    {
        private static List<Phase> SyllabusPhases = new List<Phase>()
        {
            new Phase()
            {
                Id = 0,
                Name = "Introduction to a Coding Environment",
                LearningObjectives ="Intro to TFS including source control, the development environment \r\n A review of basic development including types, operators, arrays, loops, classes \r\n A review of basic OOP principles including interfaces and abstract classes in a C# context",
                Length = 1,
                Summary ="Students will become familiar with coding in a C# environment. The week will include an introduction to Title Source specific tools and programming concepts"
            }
            ,
            new Phase()
            {
                Id = 1,
                Name = "Introduction to Automation",
                LearningObjectives ="Intro to TFS including source control, the development environment \r\n A review of basic development including types, operators, arrays, loops, classes \r\n A review of basic OOP principles including interfaces and abstract classes in a C# context",
                Length = 1,
                Summary ="Students will become familiar with coding in a C# environment. The week will include an introduction to Title Source specific tools and programming concepts"
            },
            new Phase()
            {
                Id = 2,
                Name = "Page Modelling",
                LearningObjectives ="Introduction to Captain Pav's wrappers \r\n Turning code into page models \r\n Students will create a fully functional page model",
                Length = 2,
                Summary ="Students will create a fully functional page model and provide tests for the page model to show it is accessible"
            },
            new Phase()
            {
                Id = 3,
                Name = "Fully functional testing",
                LearningObjectives ="Introduction to the lab environment \r\n Turning page models into test suites ",
                Length = 1,
                Summary ="Students will create fully functional page models, and turn them into nightly running test suites"
            }
            ,
            new Phase()
            {
                Id = 4,
                Name = "Final Project",
                LearningObjectives ="Delivery at velocity",
                Length = 2,
                Summary ="Students will create fully functional tests for both applications under test. Students will turn out as many tests as possible while following best practises."
            }

        };

        public IEnumerable<Phase> GetAllPhases()
        {
            IEnumerable<Phase> phases =
                from Phase in SyllabusPhases
                select Phase;
            return phases;
        }

        public Phase GetPhaseById(int phaseId)
        {
            IEnumerable<Phase> phases =
                from Phase in SyllabusPhases
                where Phase.Id == phaseId
                select Phase;
            return phases.FirstOrDefault();
        }
    }
}

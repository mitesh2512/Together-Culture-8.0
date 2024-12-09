using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Together_Culture.EventBo ;
namespace Together_Culture
{
    public partial class EventBo : Form
    {/*
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // e.g., "Concert", "Workshop", "Sports"
        public DateTime Date { get; set; }
        public string Description { get; set; }


        public EventBo(int id, string name, string type, DateTime date, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Date = date;
            Description = description;
        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public List<string> Preferences { get; set; } // Types of events user likes
            public List<EventBo> PastEvents { get; set; } // Events user has attended

            public User(int id, string name, List<string> preferences)
            {
                Id = id;
                Name = name;
                Preferences = preferences;
                PastEvents = new List<EventBo>();
            }

            public void AttendEvent(Event eventToAttend)
            {
                PastEvents.Add(eventToAttend);
            }

            internal void AttendEvent(EventBo eventBo)
            {
                throw new NotImplementedException();
            }
        }*//*
        public class EventRecommendation
        {
            private List<EventBo> events;
            private User user;

            public EventRecommendation(List<EventBo> events, User user)
            {
                this.events = events;
                this.user = user;
            }

            public List<EventBo> GetRecommendations()
            {
                var recommendedEvents = events
                    .Where(e => user.Preferences.Contains(e.Type) && !user.PastEvents.Any(pe => pe.Id == e.Id))
                    .OrderBy(e => e.Date) // Sort by date
                    .ToList();

                return recommendedEvents;
            }
        }*/

          

        public class Program
        {
            public static void Main(string[] args)
            {
                // Sample events
              /*  var events = new List<EventBo>
        {
            new EventBo(1, "Rock Concert", "Concert", new DateTime(2023, 10, 15), "A thrilling rock concert."),
            new EventBo(2, "Art Workshop", "Workshop", new DateTime(2023, 10, 20), "Learn to paint with professionals."),
            new EventBo(3, "Football Match", "Sports", new DateTime(2023, 10, 25), "Watch the local team play."),
            new EventBo(4, "Jazz Night", "Concert", new DateTime(2023, 11, 01), "Enjoy a night of smooth jazz."),
            new EventBo(5, "Cooking Class", "Workshop", new DateTime(2023, 11, 05), "Learn to cook Italian cuisine.")
        };

                // Sample user
                var user = new User(1, "Alice", new List<string> { "Concert", "Workshop" });
                user.AttendEvent(events[0]); // User attended the Rock Concert

                // Create recommendation engine
                var recommendationEngine = new EventRecommendation(events, user);

                // Get recommendations
                var recommendations = recommendationEngine.GetRecommendations();

                // Display recommendations
                Console.WriteLine($"Recommendations for {user.Name}:");
                foreach (var recommendedEvent in recommendations)
                {
                    Console.WriteLine($"- {recommendedEvent.Name} ({recommendedEvent.Type}) on {recommendedEvent.Date.ToShortDateString()}: {recommendedEvent.Description}");
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventDetails blankPage = new EventDetails();

            // Show the blank page
            blankPage.Show();
        }
    }
}

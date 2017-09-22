using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFApp.Models
{
    public class Speaker
    {
        public int UserId { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerTopic { get; set; }
        public string SpeakerDescription { get; set; }
        public string SpeakerImageUrl { get; set; }

        public List<Speaker> GetSpeakers()
        {
            var speakerlist = new List<Speaker>()
            {
                new Speaker
                {
                    UserId = 1,
                    SpeakerName = "Ajit Pawar",
                    SpeakerDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    SpeakerTopic = "Ajit's First Topic",
                    SpeakerImageUrl = "https://wwwf.imperial.ac.uk/blog/student-blogs/files/2017/01/stokes-profile-400-1.png",
                },
                new Speaker
                {
                    UserId = 2,
                    SpeakerName = "Mohan Mahale",
                    SpeakerDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    SpeakerTopic = "Mohan's First Topic",
                    SpeakerImageUrl = "http://www.aspph.org/app/uploads/2017/03/Ans-.jpg",
                },
                new Speaker
                {
                    UserId = 3,
                    SpeakerName = "Sachin Chakole",
                    SpeakerDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    SpeakerTopic = "Sachin's First Topic",
                    SpeakerImageUrl = "https://mediacdn.mancity.com/-/media/images/shared/players/squad-profiles-images/first-team/squad-listings/hart-profile.png",
                },
                new Speaker
                {
                    UserId = 4,
                    SpeakerName = "Pankaj Dahale",
                    SpeakerDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    SpeakerTopic = "Pankaj's First Topic",
                    SpeakerImageUrl = "https://fortunedotcom.files.wordpress.com/2017/03/justin-trudeau-grid-image1.jpg?w=414&h=240&crop=1",
                },
                new Speaker
                {
                    UserId = 5,
                    SpeakerName = "Pratik Kamble",
                    SpeakerDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    SpeakerTopic = "Pratik's First Topic",
                    SpeakerImageUrl = "https://tctechcrunch2011.files.wordpress.com/2010/07/scott-forstall.jpeg?w=270",
                },
            };
            return speakerlist;
        }

    }
}

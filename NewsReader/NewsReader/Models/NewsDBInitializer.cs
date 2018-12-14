using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewsReader.Models
{
    public class NewsDBInitializer : DropCreateDatabaseAlways<NewsModel>
    {
        protected override void Seed(NewsModel context)
        {
            IList<News> News = new List<News>();

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 7, 5),
                Title = "Are scooters safe?",
                Content = "<p>AUSTIN, Texas – Narrow, motorized scooters whisking riders around " +
                "cities like Austin and Los Angeles are meant to alleviate traffic congestion, " +
                "encourage public transit and offer a cheap transportation alternative.</p>",
                Image = "https://www.gannett-cdn.com/-mm-/41f3aff081bb0539451f84a2519091e9cf1d256c/c=16-0-563-410/local/-/media/2018/11/08/USATODAY/usatsports/ford-acquires-spin-110818-1_large.jpg?width=534&height=401&fit=crop"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 8, 10),
                Title = "Fatal collision involving billionaire's yacht under investigation",
                Content = "<p>GREAT FALLS, Mont. – The U.S. Coast Guard is investigating a fatal" +
                " collision that occurred in late October between a 332-foot yacht owned by Montana" +
                " billionaire Dennis Washington and a 65-foot fishing boat that resulted in the death" +
                " of a man and an injury to another.</p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/13/PGRF/c00fcc53-3374-48df-a42a-d09942449896-1000w_q95.jpg?width=534&height=401&fit=bounds&auto=webp"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 8, 15),
                Title = "Senate votes to halt US support for Saudi-led war in Yemen",
                Content = "<p>WASHINGTON – In a historic bipartisan rebuke of the president" +
                " and a marked shift in the long-standing U.S. alliance with Saudi Arabia," +
                " the Senate voted Thursday to try to force the Trump administration to " +
                " end its military support for the Saudi-led war in Yemen. </p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/13/USAT/5c42578a-3919-4c41-bf5d-48ccb32a09cf-EPA_USA_GOVERNMENT_SENATE_YEMEN_WAR.JPG?width=534&height=401&fit=bounds&auto=webp"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 9, 15),
                Title = "DeVos to cancel $150 million in student loan debt",
                Content = "<p>The Education Department said Thursday it will cancel $150 million" +
                " in federal student loan debt, despite Secretary Betsy DeVos' efforts to" +
                " overhaul the Obama-era policy. </p>",
                Image = "https://www.gannett-cdn.com/-mm-/c245c99e6a57ebf4dc154a9268c71ed11b4fd086/c=33-0-597-423/local/-/media/2018/08/15/USATODAY/usatsports/ap_devos_89138035-e1488312759536.jpg?width=534&height=401&fit=crop"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 10, 5),
                Title = "Police departments nationwide sent scrambling by flood of emailed bomb threats",
                Content = "<p>A torrent of bomb threats emailed to universities, businesses, schools and " +
                "news outlets Thursday from New York City to San Francisco sent police departments scrambling " +
                "to sort out what appeared to be a nationwide electronic hoax aimed at extorting bitcoin from its targets.</p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/13/USAT/0874db9d-4343-410e-abe5-878403a56191-EPA_USA_EMAIL_BOMB_THREATS.jpg?width=534&height=401&fit=bounds&auto=webp"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 10, 7),
                Title = "Suicide rates — a state by state look",
                Content = "<p>The Mountain West states have some of the highest rates of depression" +
                " and suicide in the nation. Utah had the highest rate of major depression in 2017," +
                " followed by New Mexico. Montana had the highest suicide rate in 2016, followed by" +
                " Alaska, Wyoming, New Mexico and Utah. While depression and other mental illnesses" +
                " are risk factors for suicide, not everyone who has thought about suicide has mental" +
                " illness, and not all suicides are linked to mental illness.</p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/12/USAT/e8dc0cb8-9f5c-476f-8ebc-aef6a511c108-states_montana.png"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 10, 10),
                Title = "Passages 2018: Those we’ve lost through the year",
                Content = "<p>Grammy-winning jazz and pop singer Nancy Wilson has died at age 81. " +
                "Her manager Devra Hall Levy tells The Associated Press late Thursday night, Dec. 13, " +
                "2018, that Wilson died peacefully after a long illness at her home in Pioneertown," +
                " a California desert community near Joshua Tree National Park.</p>",
                Image = "https://www.gannett-cdn.com/-mm-/dd670a69737a39de7e1993eb1afb56cc7bbef442/c=0-136-2040-2856/local/-/media/2018/12/13/USATODAY/USATODAY/636803416493004883-AP-Obit-Nancy-Wilson.JPG?width=380&height=510&fit=crop"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 10, 14),
                Title = "Michael Cohen says Trump directed him to pay hush money to keep women quiet during 2016 election",
                Content = "<p>WASHINGTON – Michael Cohen, President Donald Trump's former lawyer, " +
                "said Trump authorized hush money to two alleged mistresses because he was worried " +
                "about how their stories would affect his chances for election in 2016.</p>" +
                "<p>He knows the truth, I know the truth, others know the truth, Cohen told" +
                " ABC's Good Morning America in an interview broadcast Friday. And here is the" +
                " truth: People of the United States of America, people of the world, don't" +
                " believe what he is saying.</p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/14/USAT/ade3c2b0-52e2-4137-bf95-445de5c860e4-AFP_AFP_1BL2D1.JPG?width=534&height=401&fit=bounds&auto=webp"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 11, 6),
                Title = "Winter is coming: The coldest town in every state",
                Content = "<p>The United States can experience extreme temperatures," +
                " both hot and cold – but which town in each state experiences the " +
                "coldest weather? Before you plan your winter travels, you might want to find out. </p>",
                Image = "http://www.gannett-cdn.com/media/2018/11/02/USATODAY/usatsports/247WallSt.com-247WS-502743-imageforentry35.jpg"
            });

            News.Add(new News()
            {
                PublicationDate = new DateTime(2018, 12, 6),
                Title = "Players in Mueller probe in the spotlight again",
                Content = "<p>A federal judge has set a 3 p.m. ET deadline for special " +
                "cousel Robert Mueller to turn over all documents related to the questioning " +
                "of retired Army lieutenant general Michael Flynn by two FBI agents at the " +
                "White House in January 2017.</p>",
                Image = "https://www.gannett-cdn.com/presto/2018/12/05/USAT/86d8cd0d-4675-41a1-a9d7-c95af3f1e7b8-XXX__JG_137299_Flynn_Status_7_10_201_jmg_32609.JPG?crop=3058,2649,x1124,y112&width=534&height=401&fit=bounds&auto=webp"
            });

            context.News.AddRange(News);

            base.Seed(context);
        }
    }
}
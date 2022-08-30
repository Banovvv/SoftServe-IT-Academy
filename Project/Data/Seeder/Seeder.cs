﻿using Newtonsoft.Json;
using SoftServe_IT_Academy.Project.Models;
using System.Collections.Generic;

namespace SoftServe_IT_Academy.Project.Data.Seeder
{
    public class Seeder
    {
        #region Raw Data
        private const string _roles = "[{\"Name\":\"User\"},{\"Name\":\"Admin\"}]";
        private const string _sports = "[{\"Name\":\"Volleyball\",\"Description\":\"Volleyball is a team sport in which two teams of six players are separated by a net. Each team tries to score points by grounding a ball on the other team's court under organized rules.\"},{\"Name\":\"Tennis\",\"Description\":\"Tennis is a racket sport that is played either individually against a single opponent (singles) or between two teams of two players each (doubles).\"},{\"Name\":\"Basketball\",\"Description\":\"Basketball is a team sport in which two teams, most commonly of five players each, opposing one another on a rectangular court, compete with the primary objective of shooting a basketball (approximately 9.4 inches (24 cm) in diameter) through the defender's hoop (a basket 18 inches (46 cm) in diameter mounted 10 feet (3.048 m) high to a backboard at each end of the court, while preventing the opposing team from shooting through their own hoop.\"},{\"Name\":\"Baseball\",\"Description\":\"Baseball is a bat-and-ball sport played between two teams of nine players each, taking turns batting and fielding. The game is in play when a player on the fielding team, called the pitcher, throws a ball that a player on the batting team tries to hit with a bat. The objective of the offensive team (batting team) is to hit the ball into the field of play, away from the other team's players, allowing its players to run the bases, having them advance counter-clockwise around four bases to score what are called runs. The objective of the defensive team (referred to as the fielding team) is to prevent batters from becoming runners, and to prevent runners' advance around the bases.\"},{\"Name\":\"Cricket\",\"Description\":\"Cricket is a bat-and-ball game played between two teams of eleven players each on a field at the centre of which is a 22-yard (20-metre) pitch with a wicket at each end, each comprising two bails balanced on three stumps. The game proceeds when a player on the fielding team, called the bowler, bowls (propels) the ball from one end of the pitch towards the wicket at the other end, with an over being completed once they have legally done so six times.\"},{\"Name\":\"Quidditch\",\"Description\":\"Quidditch, also known as quadball, is a sport of two teams of seven players each mounted on a broomstick, and is played on a hockey rink-sized pitch. The sport was created in 2005 at Middlebury College in Vermont, and was inspired by the fictional game Quidditch in the Harry Potter books by author J. K. Rowling.\"},{\"Name\":\"Snooker\",\"Description\":\"Snooker is a cue sport played on a rectangular table covered with a green cloth called baize, with six pockets, one at each corner and one in the middle of each long side. First played by British Army officers stationed in India in the second half of the 19th century, the game is played with twenty-two balls, comprising a cue ball, fifteen red balls, and six other balls—a yellow, green, brown, blue, pink, and black—collectively called the colours.\"},{\"Name\":\"Football\",\"Description\":\"Football is a family of team sports that involve, to varying degrees, kicking a ball to score a goal. Unqualified, the word football normally means the form of football that is the most popular where the word is used.\"},{\"Name\":\"Orienteering\",\"Description\":\"Orienteering is a group of sports that require navigational skills using a map and compass to navigate from point to point in diverse and usually unfamiliar terrain whilst moving at speed. Participants are given a topographical map, usually a specially prepared orienteering map, which they use to find control points.\"},{\"Name\":\"Hockey\",\"Description\":\"Hockey is a term used to denote various types of both summer and winter team sports which originated on either an outdoor field, sheet of ice, or dry floor such as in a gymnasium.\"}]";
        private const string _leagues = "[{\"Name\":\"National Basketball Association\",\"Description\":\"The National Basketball Association(NBA) is a professional basketball league in North America.The league is composed of 30 teams (29 in the United States and 1 in Canada) and is one of the major professional sports leagues in the United States and Canada.It is the premier men's professional basketball league in the world.\",\"SportId\":3},{\"Name\":\"FIBA Intercontinental Cup\",\"Description\":\"The FIBA Intercontinental Cup, also commonly referred to as the FIBA World Cup for Champion Clubs, or the FIBA Club World Cup, is a professional basketball clubs competition that is endorsed by FIBA and the NBA.\",\"SportId\":3},{\"Name\":\"Bangladesh Premier League\",\"Description\":\"The BPL is one of the three professional cricket leagues in Bangladesh. It is the 16th most attended premier league in the world. In winter, each team faces the other twice in the league stage.\",\"SportId\":5},{\"Name\":\"Bulgarian Volleyball League\",\"Description\":\"The Bulgarian Men's Volleyball League is a men's volleyball competition organized by the Bulgarian Volleyball Federation, it was created in 1945.\",\"SportId\":1},{\"Name\":\"Association of Tennis Professionals\",\"Description\":\"The Association of Tennis Professionals (ATP) is the governing body of the men's professional tennis circuits – the ATP Tour, the ATP Challenger Tour and the ATP Champions Tour.\",\"SportId\":2},{\"Name\":\"Major League Baseball\",\"Description\":\"Major League Baseball (MLB) is a professional baseball organization and the oldest major professional sports league in the world.\",\"SportId\":3},{\"Name\":\"United States Quidditch Association\",\"Description\":\"In 2007 the United States Quidditch Association, back then named the Intercollegiate Quidditch Association or (I.Q.A), was founded to regulate quidditch in the United States and abroad, a very popular sport amongst college students.\",\"SportId\":6},{\"Name\":\"World Snooker Tour\",\"Description\":\"The World Snooker Tour (WST) is the main professional snooker tour, consisting of approximately 128 players competing on a circuit of up to 28 tournaments each season.\",\"SportId\":8},{\"Name\":\"UEFA Champions League\",\"Description\":\"The UEFA Champions League (abbreviated as UCL) is an annual club football competition organised by the Union of European Football Associations (UEFA) and contested by top-division European clubs, deciding the competition winners through a round robin group stage to qualify for a double-legged knockout format, and a single leg final. It is one of the most prestigious football tournaments in the world and the most prestigious club competition in European football, played by the national league champions (and, for some nations, one or more runners-up) of their national associations.\",\"SportId\":8},{\"Name\":\"World Orienteering Championships\",\"Description\":\"The World Orienteering Championships (WOC) is an annual event organised by the International Orienteering Federation. The first World Championships was held in Fiskars, Finland in 1966. They were held biennially up to 2003 (with the exception of 1978 and 1979). Since 2003, competitions have been held annually.\",\"SportId\":9},{\"Name\":\"National Hockey League \",\"Description\":\"The National Hockey League is a professional ice hockey league in North America comprising 32 teams—25 in the United States and 7 in Canada. It is considered to be the top ranked professional ice hockey league in the world.\",\"SportId\":10}]";
        private const string _states = "[{\"Name\":\"Draft\"},{\"Name\":\"Published\"},{\"Name\":\"Deleted\"}]";
        private const string _users = "[{\"Email\":\"admin@admin.com\",\"Username\":\"admin\",\"DisplayName\":\"Administrator\",\"Pseudonym\":\"Admin\",\"FirstName\":\"Admin\",\"LastName\":\"Admin\",\"Password\":\"@dm1n\",\"RoleId\":2},{\"Email\":\"notadmin@admin.com\",\"Username\":\"notadmin\",\"DisplayName\":\"NotAnAdministrator\",\"Pseudonym\":\"NotAdmin\",\"FirstName\":\"NotAdmin\",\"LastName\":\"NotAdmin\",\"Password\":\"n0t@dm1n\",\"RoleId\":1}]";
        #endregion

        public static void Seed(ApplicationDbContext context)
        {
            SeedRoles(context);
            SeedSports(context);
            SeedLeagues(context);
            SeedStates(context);
            SeedUsers(context);
        }

        private static void SeedRoles(ApplicationDbContext context)
        {
            IEnumerable<Role> roles = JsonConvert.DeserializeObject<List<Role>>(_roles);

            context.Roles.AddRange(roles);
            context.SaveChanges();
        }
        private static void SeedSports(ApplicationDbContext context)
        {
            IEnumerable<Sport> sports = JsonConvert.DeserializeObject<List<Sport>>(_sports);

            context.Sports.AddRange(sports);
            context.SaveChanges();
        }
        private static void SeedLeagues(ApplicationDbContext context)
        {
            IEnumerable<League> leagues = JsonConvert.DeserializeObject<List<League>>(_leagues);

            context.Leagues.AddRange(leagues);
            context.SaveChanges();
        }
        private static void SeedStates(ApplicationDbContext context)
        {
            IEnumerable<State> states = JsonConvert.DeserializeObject<List<State>>(_states);

            context.States.AddRange(states);
            context.SaveChanges();
        }
        private static void SeedUsers(ApplicationDbContext context)
        {
            IEnumerable<User> users = JsonConvert.DeserializeObject<List<User>>(_users);

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}

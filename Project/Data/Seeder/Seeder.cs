﻿namespace SoftServe_IT_Academy.Project.Data.Seeder
{
    public class Seeder
    {
        #region Raw Data
        private readonly string _roles = "[{\"Name\":\"User\"},{\"Name\":\"Admin\"}]";
        private readonly string _sports = "[{\"Name\":\"Volleyball\",\"Description\":\"Volleyball is a team sport in which two teams of six players are separated by a net. Each team tries to score points by grounding a ball on the other team's court under organized rules.\"},{\"Name\":\"Tennis\",\"Description\":\"Tennis is a racket sport that is played either individually against a single opponent (singles) or between two teams of two players each (doubles). Each player uses a tennis racket that is strung with cord to strike a hollow rubber ball covered with felt over or around a net and into the opponent's court. The object of the game is to manoeuvre the ball in such a way that the opponent is not able to play a valid return. The player who is unable to return the ball validly will not gain a point, while the opposite player will.\"},{\"Name\":\"Basketball\",\"Description\":\"Basketball is a team sport in which two teams, most commonly of five players each, opposing one another on a rectangular court, compete with the primary objective of shooting a basketball (approximately 9.4 inches (24 cm) in diameter) through the defender's hoop (a basket 18 inches (46 cm) in diameter mounted 10 feet (3.048 m) high to a backboard at each end of the court, while preventing the opposing team from shooting through their own hoop.\"},{\"Name\":\"Baseball\",\"Description\":\"Baseball is a bat-and-ball sport played between two teams of nine players each, taking turns batting and fielding. The game is in play when a player on the fielding team, called the pitcher, throws a ball that a player on the batting team tries to hit with a bat. The objective of the offensive team (batting team) is to hit the ball into the field of play, away from the other team's players, allowing its players to run the bases, having them advance counter-clockwise around four bases to score what are called runs. The objective of the defensive team (referred to as the fielding team) is to prevent batters from becoming runners, and to prevent runners' advance around the bases.\"},{\"Name\":\"Cricket\",\"Description\":\"Cricket is a bat-and-ball game played between two teams of eleven players each on a field at the centre of which is a 22-yard (20-metre) pitch with a wicket at each end, each comprising two bails balanced on three stumps. The game proceeds when a player on the fielding team, called the bowler, bowls (propels) the ball from one end of the pitch towards the wicket at the other end, with an over being completed once they have legally done so six times.\"},{\"Name\":\"Quidditch\",\"Description\":\"Quidditch, also known as quadball, is a sport of two teams of seven players each mounted on a broomstick, and is played on a hockey rink-sized pitch. The sport was created in 2005 at Middlebury College in Vermont, and was inspired by the fictional game Quidditch in the Harry Potter books by author J. K. Rowling.\"},{\"Name\":\"Snooker\",\"Description\":\"Snooker is a cue sport played on a rectangular table covered with a green cloth called baize, with six pockets, one at each corner and one in the middle of each long side. First played by British Army officers stationed in India in the second half of the 19th century, the game is played with twenty-two balls, comprising a cue ball, fifteen red balls, and six other balls—a yellow, green, brown, blue, pink, and black—collectively called the colours.\"},{\"Name\":\"Football\",\"Description\":\"Football is a family of team sports that involve, to varying degrees, kicking a ball to score a goal. Unqualified, the word football normally means the form of football that is the most popular where the word is used.\"},{\"Name\":\"Orienteering\",\"Description\":\"Orienteering is a group of sports that require navigational skills using a map and compass to navigate from point to point in diverse and usually unfamiliar terrain whilst moving at speed. Participants are given a topographical map, usually a specially prepared orienteering map, which they use to find control points.\"},{\"Name\":\"\",\"Description\":\"\"},{\"Name\":\"\",\"Description\":\"\"},{\"Name\":\"Hockey\",\"Description\":\"Hockey is a term used to denote various types of both summer and winter team sports which originated on either an outdoor field, sheet of ice, or dry floor such as in a gymnasium.\"}]";
        #endregion

        public static void Seed(ApplicationDbContext context)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
  public class WorldContextSeedData
  {
    private WorldContext _context;

    public WorldContextSeedData(WorldContext context)
    {
      _context = context;
    }
    public void EnsureSeedData()
    {
      if (!_context.Trips.Any())
      {
        // Add new Data
        var usTrip = new Trip()
        {
          Name = "Us trip",
          Created = DateTime.UtcNow,
          UserName = "",
          Stops = new List<Stop>()
          {
            new Stop(){Name="Atlanta, GA", Arrival=new DateTime(2014,6,4), Latitude=33.748995,Longitude=-84.387982,Order=0},
            new Stop(){Name="New York, NY", Arrival=new DateTime(2014,6,9),Latitude=40.712784,Longitude=-74.005941,Order=1},
            new Stop(){Name="Boston, MA", Arrival=new DateTime(2014,7,1),Latitude=42.360082,Longitude=-71.058880,Order=2},
            new Stop(){Name="Chicago, IL", Arrival=new DateTime(2014,7,10),Latitude=41.878114,Longitude=-87.629798,Order=3},
            new Stop(){Name="Seattle, WA", Arrival=new DateTime(2014,8,13),Latitude=47.606209,Longitude=-122.332071,Order=4},
            new Stop(){Name="Atlanta, GA", Arrival=new DateTime(2014,8,23),Latitude=33.748995,Longitude=-84.387982,Order=5}
          }
        };

        _context.Trips.Add(usTrip);
        _context.Stops.AddRange(usTrip.Stops);

        var worldTrip = new Trip()
        {
          Name = "World Trip",
          Created = DateTime.UtcNow,
          UserName = "",
          Stops = new List<Stop>()
          {
new Stop(){ Order=0 , Latitude=  -52.3345042,Longitude=  46.35781361  , Arrival=new DateTime(2014,  1,1 ),  Name="	1	5	"},
new Stop(){ Order=1 , Latitude=  22.13799909,Longitude=  -33.39134206 , Arrival=new DateTime(2014,  1,2 ),  Name="	2	6	"},
new Stop(){ Order=2 , Latitude=  12.40231222,Longitude=  13.94658189  , Arrival=new DateTime(2014,  1,3 ),  Name="	3	7	"},
new Stop(){ Order=3 , Latitude=  -11.96117692,Longitude=  175.30207969  , Arrival=new DateTime(2014,  1,4 ),  Name="	4	8	"},
new Stop(){ Order=4 , Latitude= -59.70807528,Longitude=  -119.82703487  , Arrival=new DateTime(2014,  1,5 ),  Name="	5	9	"},
new Stop(){ Order=5 , Latitude= 22.02840337,Longitude=-6.38666448 , Arrival=new DateTime(2014,  1,6 ),  Name="	6	10	"},
new Stop(){ Order=6 , Latitude=7.68798026,Longitude=  158.56397635  , Arrival=new DateTime(2014,  1,7 ),  Name="	7	11	"},
new Stop(){ Order=7 , Latitude= 47.05408321,Longitude= -56.38814232 , Arrival=new DateTime(2014,  1,8 ),  Name="	8	12	"},
new Stop(){ Order=8 , Latitude= 21.93787975,Longitude=  136.79325841  , Arrival=new DateTime(2014,  1,9 ),  Name="	9	13	"},
new Stop(){ Order=9 , Latitude= 24.11195462,Longitude=  110.83255214  , Arrival=new DateTime(2014,  1,10  ),  Name="	10	14	"},
new Stop(){ Order=10  , Latitude= 32.15081417,Longitude=  170.0284949 , Arrival=new DateTime(2014,  1,11  ),  Name="	11	15	"},
new Stop(){ Order=11  , Latitude= -10.81736212,Longitude= -78.52735169  , Arrival=new DateTime(2014,  1,12  ),  Name="	12	16	"},
new Stop(){ Order=12  , Latitude=7.08873019,Longitude=  -144.25341724 , Arrival=new DateTime(2014,  1,13  ),  Name="	13	17	"},
new Stop(){ Order=13  , Latitude=5.20181864,Longitude= 81.56613642  , Arrival=new DateTime(2014,  1,14  ),  Name="	14	18	"},
new Stop(){ Order=14  , Latitude= -14.76272672,Longitude= 23.42911187 , Arrival=new DateTime(2014,  1,15  ),  Name="	15	19	"},
new Stop(){ Order=15  , Latitude= -27.123714,Longitude=  136.60648581 , Arrival=new DateTime(2014,  1,16  ),  Name="	16	20	"},
new Stop(){ Order=16  , Latitude= 25.43706439,Longitude=-6.55203994 , Arrival=new DateTime(2014,  1,17  ),  Name="	17	21	"},
new Stop(){ Order=17  , Latitude= 22.79013563,Longitude= -68.26766403 , Arrival=new DateTime(2014,  1,18  ),  Name="	18	22	"},
new Stop(){ Order=18  , Latitude= -19.65776378,Longitude= -71.97945892  , Arrival=new DateTime(2014,  1,19  ),  Name="	19	23	"},
new Stop(){ Order=19  , Latitude= -22.83802763,Longitude= -47.33754863  , Arrival=new DateTime(2014,  1,20  ),  Name="	20	24	"},
new Stop(){ Order=20  , Latitude= 19.61634131,Longitude= -16.11364338 , Arrival=new DateTime(2014,  1,21  ),  Name="	21	25	"},
new Stop(){ Order=21  , Latitude= 47.1895131,Longitude=-6.90037194  , Arrival=new DateTime(2014,  1,22  ),  Name="	22	26	"},
new Stop(){ Order=22  , Latitude= -61.65593386,Longitude=  -172.92723529  , Arrival=new DateTime(2014,  1,23  ),  Name="	23	27	"},
new Stop(){ Order=23  , Latitude=-9.10781173,Longitude= 67.05199808 , Arrival=new DateTime(2014,  1,24  ),  Name="	24	28	"},
new Stop(){ Order=24  , Latitude= 15.13799755,Longitude=  -165.84352291 , Arrival=new DateTime(2014,  1,25  ),  Name="	25	29	"},
new Stop(){ Order=25  , Latitude= 24.79929,Longitude=  175.03260499 , Arrival=new DateTime(2014,  1,26  ),  Name="	26	30	"},
new Stop(){ Order=26  , Latitude=9.3646192,Longitude=  -125.43413607  , Arrival=new DateTime(2014,  1,27  ),  Name="	27	31	"},
new Stop(){ Order=27  , Latitude= 49.94485954,Longitude=  -151.51035881 , Arrival=new DateTime(2014,  1,28  ),  Name="	28	32	"},
new Stop(){ Order=28  , Latitude= -52.73113844,Longitude= -95.48055937  , Arrival=new DateTime(2014,  1,29  ),  Name="	29	33	"},
new Stop(){ Order=29  , Latitude= -33.67529304,Longitude= 44.76370505 , Arrival=new DateTime(2014,  1,30  ),  Name="	30	34	"},
new Stop(){ Order=30  , Latitude= -10.1134074,Longitude=  -127.22499992 , Arrival=new DateTime(2014,  1,31  ),  Name="	31	35	"},
new Stop(){ Order=31  , Latitude= -57.00449981,Longitude=-1.90183853  , Arrival=new DateTime(2014,  2,1 ),  Name="	32	36	"},
new Stop(){ Order=32  , Latitude= -25.74402379,Longitude=  -114.7669234 , Arrival=new DateTime(2014,  2,2 ),  Name="	33	37	"},
new Stop(){ Order=33  , Latitude=-2.01290251,Longitude=  126.74705328 , Arrival=new DateTime(2014,  2,3 ),  Name="	34	38	"},
new Stop(){ Order=34  , Latitude= 53.21209339,Longitude= -79.96039006 , Arrival=new DateTime(2014,  2,4 ),  Name="	35	39	"},
new Stop(){ Order=35  , Latitude= -11.76623086,Longitude= 99.45000355 , Arrival=new DateTime(2014,  2,5 ),  Name="	36	40	"},
new Stop(){ Order=36  , Latitude= -48.75922048,Longitude=  -119.30343398  , Arrival=new DateTime(2014,  2,6 ),  Name="	37	41	"},
new Stop(){ Order=37  , Latitude= 38.75564529,Longitude= 32.57930175  , Arrival=new DateTime(2014,  2,7 ),  Name="	38	42	"},
new Stop(){ Order=38  , Latitude= 54.32505297,Longitude= -49.79080084 , Arrival=new DateTime(2014,  2,8 ),  Name="	39	43	"},
new Stop(){ Order=39  , Latitude=-0.68636996,Longitude=  155.2791671  , Arrival=new DateTime(2014,  2,9 ),  Name="	40	44	"},
new Stop(){ Order=40  , Latitude= -58.93487112,Longitude=  163.25151738 , Arrival=new DateTime(2014,  2,10  ),  Name="	41	45	"},
new Stop(){ Order=41  , Latitude= -31.52097632,Longitude=  172.52536057 , Arrival=new DateTime(2014,  2,11  ),  Name="	42	46	"},
new Stop(){ Order=42  , Latitude= 51.92727319,Longitude= -27.25253943 , Arrival=new DateTime(2014,  2,12  ),  Name="	43	47	"},
new Stop(){ Order=43  , Latitude=-1.57924442,Longitude= -98.10626653  , Arrival=new DateTime(2014,  2,13  ),  Name="	44	48	"},
new Stop(){ Order=44  , Latitude= -60.43526054,Longitude=  -113.45618519  , Arrival=new DateTime(2014,  2,14  ),  Name="	45	49	"},
new Stop(){ Order=45  , Latitude= 42.99849745,Longitude=  160.57516777  , Arrival=new DateTime(2014,  2,15  ),  Name="	46	50	"},
new Stop(){ Order=46  , Latitude= 22.32891806,Longitude= -53.02141431 , Arrival=new DateTime(2014,  2,16  ),  Name="	47	51	"},
new Stop(){ Order=47  , Latitude= -53.53834648,Longitude= -12.93495632  , Arrival=new DateTime(2014,  2,17  ),  Name="	48	52	"},
new Stop(){ Order=48  , Latitude=7.32795018,Longitude= 57.1601313 , Arrival=new DateTime(2014,  2,18  ),  Name="	49	53	"},
new Stop(){ Order=49  , Latitude= 53.38720393,Longitude= -90.91598648 , Arrival=new DateTime(2014,  2,19  ),  Name="	50	54	"}
        }
        };

        _context.Trips.Add(worldTrip);
        _context.Stops.AddRange(worldTrip.Stops);
        _context.SaveChanges();
      }
    }
  }
}

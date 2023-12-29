using CityInfo.API.Model;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        //public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id= 1,
                    Name="Kiev",
                    Description="Divided by the Dnipro River",
                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name="Shevchenko Park",
                            Description="Near it is located the red building of the KNU" },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name="Glass bridge",
                            Description="This bridge was built by the mayor of Kyiv" }


                    }


                },

                new CityDto()
                {
                    Id= 2,
                    Name="Lviv",
                    Description="The largest cemetery is Lychakivskoye",

                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                      new PointOfInterestDto()
                      {
                          Id=1,
                          Name="Town hall",
                          Description="Lviv city administration building" },

                      new PointOfInterestDto()
                      {
                          Id=2,
                          Name="Lviv Opera House",
                          Description="Named after the famous Ukrainian opera singer Solomiya Krushelnitskaya"
                      }
                      
                    }
                },

                new CityDto()
                {
                    Id= 3,
                    Name="Ivano-Frankivsk",
                    Description="The Old Man Lives There",

                    PointOfInterests = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                          Id=1,
                          Name="Ivano-Frankivsk Town Hall",
                          Description="Building in the center of Ivano-Frankivsk on Rynok Square" },

                        new PointOfInterestDto()
                        {
                          Id=2,
                          Name="Market Square",
                          Description="Main square of Ivano-Frankivsk, historical city center"
                        }

                    }
                }


            };
        }
    }
}

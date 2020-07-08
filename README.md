# How to draw the polygons on a SfMaps in Xamarin.Forms

This demo sample explains how to draw the polygons on a SfMaps in Xamarin.Forms.

## Polygon

Polygon is a two-dimensional surface stored as a sequence of points defining its exterior bounding ring and 0 or more interior rings. Polygons are always simple. Mostly the polygon shape type defines a group of land, water bodies, and other features that have a spatial extent.

[Polygon shapes with maps](Output/Maps_polygon.png)

To get the desired output as shown above, please use the below XAML code to construct its UI

**[XAML]**

```
<maps:SfMaps x:Name="sfmap" ZoomLevel="4">
        <maps:SfMaps.Layers>
            <maps:ImageryLayer LayerType="OSM" GeoCoordinates="30.9709225,-100.2187212" >
                <maps:ImageryLayer.Sublayers>
                    <maps:ShapeFileLayer  ShapeType="Polygon" Points="{Binding SubLayer1}" >
                        <maps:ShapeFileLayer.ShapeSettings>
                            <maps:ShapeSetting ShapeFill="Blue" ShapeStroke="DarkBlue" 
                                               ShapeStrokeThickness="4" />
                        </maps:ShapeFileLayer.ShapeSettings>
                    </maps:ShapeFileLayer>
                    <maps:ShapeFileLayer  ShapeType="Polygon" Points="{Binding SubLayer2}">
                        <maps:ShapeFileLayer.ShapeSettings>
                            <maps:ShapeSetting ShapeFill="Orange" ShapeStroke="Red"
                                               ShapeStrokeThickness="4" />
                        </maps:ShapeFileLayer.ShapeSettings>
                    </maps:ShapeFileLayer>
                </maps:ImageryLayer.Sublayers>
            </maps:ImageryLayer>
        </maps:SfMaps.Layers>
    </maps:SfMaps>

```
This polygon's points get from ViewModel class as shown in below

**[C#]**

```
 public class ViewModel
    {
        public ObservableCollection<Point> SubLayer1
        {
            get; set;
        }

        public ObservableCollection<Point> SubLayer2
        {
            get; set;
        }
        public ViewModel()
        {

            SubLayer1 = new ObservableCollection<Point>()
            {
                new Point(37.042972,-109.085003),
                new Point(40.992567,-109.021030),
                new Point(40.968420,-102.048065),
                new Point(36.991893,-102.144024),
                new Point(37.042972,-109.085003)
            };
            SubLayer2 = new ObservableCollection<Point>()
            {
              new Point(41.04621681452063, -104.0625),
              new Point(41.04621681452063, -102.0849609375),
              new Point(40.01078714046552, -102.041015625),
              new Point(40.04443758460856, -95.44921875),
              new Point(42.48830197960227, -96.3720703125),
              new Point(43.03677585761058, -98.4375),
              new Point(43.068887774169625, -104.0625),
              new Point(41.04621681452063, -104.0625),
            };
        }
    }

    ```


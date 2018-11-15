<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/MapCoordinatePatterns/Form1.cs) (VB: [Form1.vb](./VB/MapCoordinatePatterns/Form1.vb))
<!-- default file list end -->
# How to format values of map point coordinates displayed in the navigation panel


<p>This example demonstrates how to change a text of map point coordinates displayed in the navigation panel using latitude and longitude format patterns.<br />
</p><br />



<h3>Description</h3>

<p>To do this, specify a string that will represent the pattern displayed within a coordinate label in the map navigation panel using<strong> NavigationPanelOptions.LatitudePattern</strong> and <strong>NavigationPanelOptions.LongitudePattern</strong> properties.</p><p>In this example you can format values of map point coordinates using a predefined list of patterns from the combo box. In the combo box you can also specify a custom pattern using standard specifiers together with placeholders. For example: &quot;<strong>{CP}{D}&#176;{M}&#39;{S:2}&#39;&#39;</strong> &quot;, where CP – is a cardinal point; D – is a degree; M -  is a minute; S – is a second.  Note that the precision specifier (&quot;2&quot;) indicates the desired number of decimal places. </p><p><br />
</p>

<br/>



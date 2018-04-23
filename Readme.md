# How to format values of map point coordinates displayed in the navigation panel


<p>This example demonstrates how to change a text of map point coordinates displayed in the navigation panel using latitude and longitude format patterns.<br />
</p><br />



<h3>Description</h3>

<p>To do this, specify a string that will represent the pattern displayed within a coordinate label in the map navigation panel using&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapNavigationPanelOptions_XCoordinatePatterntopic">NavigationPanelOptions.XCoordinatePattern</a> and&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapNavigationPanelOptions_YCoordinatePatterntopic">NavigationPanelOptions.YCoordinatePattern</a> properties.<br />In this example you can format values of map point coordinates using a predefined list of patterns from the combo box. In the combo box you can also specify a custom pattern using standard specifiers together with placeholders. For example: "<strong>{CP}{D}&deg;{M}'{S:2}''</strong> ", where CP &ndash; is a cardinal point; D &ndash; is a degree; M - is a minute; S &ndash; is a second. Note that the precision specifier ("2") indicates the desired number of decimal places.</p>

<br/>



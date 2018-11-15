<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication1/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/WpfApplication1/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication1/MainWindow.xaml.vb))
<!-- default file list end -->
# How to sequentially animate texts in a Digital Gauge control


<p>The following sample demonstrates how to use creeping line and blinking animation effects to imitate the work of the advertising indicator board.</p>


<h3>Description</h3>

<p>To accomplish this task, it is necessary to create a <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfGaugesCreepingLineAnimationtopic"><u>CreepingLineAnimation</u></a> object and assign it to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfGaugesSymbolViewBase_Animationtopic"><u>MatrixView8x14.Animation</u></a> property. Then handle the <strong>CreepingLineAnimationCompleted</strong> event and assign a new <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfGaugesBlinkingAnimationtopic"><u>BlinkingAnimation</u></a> object to the <a href="http://help.devexpress.com/#WPF/DevExpressXpfGaugesSymbolViewBase_Animationtopic"><u>MatrixView8x14.Animation</u></a> property.</p><p><br />
Note that in this example two texts have different number of symbols: the first (&quot;Do you want to learn more?&quot;) -<strong> 26</strong>, the second  (&quot;www.devexpress.com&quot;) - <strong>18</strong> characters. To prevent animation of space symbols in the second text and demonstrate  the creeping line animation for the entire text, the <a href="http://help.devexpress.com/#WPF/DevExpressXpfGaugesDigitalGaugeControl_SymbolCounttopic"><u>DigitalGaugeControl.SymbolCount</u></a>, <a href="http://help.devexpress.com/#WPF/DevExpressXpfGaugesCreepingLineAnimation_StartSpacestopic"><u>CreepingLineAnimation.StartSpaces</u></a> and <a href="http://help.devexpress.com/#WPF/DevExpressXpfGaugesCreepingLineAnimation_AdditionalSpacestopic"><u>CreepingLineAnimation.AdditionalSpaces</u></a> properties are set to the values that correspond to the required number of characters.</p><p><br />
</p>

<br/>



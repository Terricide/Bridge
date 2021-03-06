﻿// The documentation for this class (on <summary> tags) was extracted from:
// https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D

using Bridge;

namespace Bridge.Html5
{
    /// <summary>
    /// The CanvasRenderingContext2D interface provides the 2D rendering context for the drawing surface of a
    /// <canvas> element.
    /// To get an object of this interface, call getContext() on a <canvas>, supplying
    /// "CanvasContext2DType.CanvasRenderingContext2D" as the argument.
    /// </summary>
    [Ignore]
    [Namespace(false)]
    public class CanvasRenderingContext2D : SVGOperations
    {
        /// <summary>
        /// There are three methods that immediately draw rectangles to the bitmap.
        /// </summary>
        #region Drawing Rectangles

        // TODO: Review summary to include parameters' info. From this point down to createPattern (~390)
        /// <summary>
        /// Sets all pixels in the rectangle defined by starting point (x, y) and size (width, height)
        /// to transparent black, erasing any previously drawn content.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void ClearRect(uint x, uint y, uint width, uint height)
        {
            return;
        }

        /// <summary>
        /// Sets all pixels in the rectangle defined by starting point (x, y) and size (width, height)
        /// to transparent black, erasing any previously drawn content.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void ClearRect(int x, int y, int width, int height)
        {
            return;
        }

        /// <summary>
        /// Draws a filled rectangle at (x, y) position whose size is determined by width and height.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void FillRect(uint x, uint y, uint width, uint height)
        {
            return;
        }

        /// <summary>
        /// Draws a filled rectangle at (x, y) position whose size is determined by width and height.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void FillRect(int x, int y, int width, int height)
        {
            return;
        }

        /// <summary>
        /// Paints a rectangle which has a starting point at (x, y) and has a w width and an h height
        /// onto the canvas, using the current stroke style.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void StrokeRect(uint x, uint y, uint width, uint height)
        {
            return;
        }

        /// <summary>
        /// Paints a rectangle which has a starting point at (x, y) and has a w width and an h height
        /// onto the canvas, using the current stroke style.
        /// </summary>
        /// <param name="x">The x axis of the coordinate for the rectangle starting point.</param>
        /// <param name="y">The y axis of the coordinate for the rectangle starting point.</param>
        /// <param name="width">The rectangle's width.</param>
        /// <param name="height">The rectangle's height.</param>
        public virtual void StrokeRect(int x, int y, int width, int height)
        {
            return;
        }

        #endregion

        /// <summary>
        /// The following methods are provided for drawing text. See also the TextMetrics object for
        /// text properties.
        /// </summary>
        #region Drawing Text

        /// <summary>
        /// Draws (fills) a given text at the given (x,y) position.
        // </summary>
        /// </summary>
        /// <param name="text">
        /// The text to render using the current font, textAlign, textBaseline, and direction values.
        /// </param>
        /// <param name="x">The x axis of the coordinate for the text starting point.</param>
        /// <param name="y">The y axis of the coordinate for the text starting point.</param>
        /// <param name="maxWidth">
        /// The maximum width to draw. If specified, and the string is computed to be wider than
        /// this width, the font is adjusted to use a more horizontally condensed font (if one is
        /// available or if a reasonably readable one can be synthesized by scaling the current
        /// font horizontally) or a smaller font.
        /// </param>
        public virtual void FillText(string text, uint x, uint y, uint? maxWidth = null)
        {
            return;
        }

        /// <summary>
        /// Draws (fills) a given text at the given (x,y) position.
        /// </summary>
        /// <param name="text">
        /// The text to render using the current font, textAlign, textBaseline, and direction values.
        /// </param>
        /// <param name="x">The x axis of the coordinate for the text starting point.</param>
        /// <param name="y">The y axis of the coordinate for the text starting point.</param>
        /// <param name="maxWidth">
        /// The maximum width to draw. If specified, and the string is computed to be wider than
        /// this width, the font is adjusted to use a more horizontally condensed font (if one is
        /// available or if a reasonably readable one can be synthesized by scaling the current
        /// font horizontally) or a smaller font.
        /// </param>
        public virtual void FillText(string text, int x, int y, int? maxWidth = null)
        {
            return;
        }

        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text">
        /// The text to render using the current font, textAlign, textBaseline, and direction values.
        /// </param>
        /// <param name="x">The x axis of the coordinate for the text starting point.</param>
        /// <param name="y">The y axis of the coordinate for the text starting point.</param>
        /// <param name="maxWidth">
        /// The maximum width to draw. If specified, and the string is computed to be wider than
        /// this width, the font is adjusted to use a more horizontally condensed font (if one is
        /// available or if a reasonably readable one can be synthesized by scaling the current
        /// font horizontally) or a smaller font.
        /// </param>
        public virtual void StrokeText(string text, uint x, uint y, uint? maxWidth = null)
        {
            return;
        }

        /// <summary>
        /// Draws (strokes) a given text at the given (x, y) position.
        /// </summary>
        /// <param name="text">
        /// The text to render using the current font, textAlign, textBaseline, and direction values.
        /// </param>
        /// <param name="x">The x axis of the coordinate for the text starting point.</param>
        /// <param name="y">The y axis of the coordinate for the text starting point.</param>
        /// <param name="maxWidth">
        /// The maximum width to draw. If specified, and the string is computed to be wider than
        /// this width, the font is adjusted to use a more horizontally condensed font (if one is
        /// available or if a reasonably readable one can be synthesized by scaling the current
        /// font horizontally) or a smaller font.
        /// </param>
        public virtual void StrokeText(string text, int x, int y, int? maxWidth = null)
        {
            return;
        }

        /// <summary>
        /// Returns a TextMetrics object.
        /// </summary>
        /// <param name="text">The text to measure.</param>
        /// <returns>A TextMetrics object.</returns>
        public virtual TextMetrics MeasureText(string text)
        {
            return null;
        }

        #endregion

        /// <summary>
        /// The following methods and properties control how lines are drawn.
        /// </summary>
        #region Line Styles

        /// <summary>
        /// Width of lines. Default 1.0
        /// </summary>
        public double LineWidth;

        /// <summary>
        /// Type of endings on the end of lines. Possible values: butt (default), round, square.
        /// </summary>
        public CanvasTypes.CanvasLineCapType LineCap;

        /// <summary>
        /// Defines the type of corners where two lines meet. Possible values: round, bevel, miter (default).
        /// </summary>
        public CanvasTypes.CanvasLineJoinType LineJoin;

        /// <summary>
        /// Miter limit ratio. Default 10.
        /// </summary>
        public double MiterLimit;

        /// <summary>
        /// Gets the current line dash pattern.
        /// </summary>
        /// <returns>
        /// An Array. A list of numbers that specifies distances to alternately draw a line and a gap
        /// (in coordinate space units). If the number, when setting the elements, was odd, the elements
        /// of the array get copied and concatenated.
        /// For example, setting the line dash to [5, 15, 25] will result in getting back
        /// [5, 15, 25, 5, 15, 25].
        /// </returns>
        public virtual double[] GetLineDash()
        {
            return null;
        }

        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments">
        /// An Array. A list of numbers that specifies distances to alternately draw a line and a gap
        /// (in coordinate space units). If the number of elements in the array is odd, the elements
        /// of the array get copied and concatenated.
        /// For example, [5, 15, 25] will become [5, 15, 25, 5, 15, 25].
        /// </param>
        public virtual void SetLineDash(double[] segments)
        {
            return;
        }

        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments">
        /// An Array. A list of numbers that specifies distances to alternately draw a line and a gap
        /// (in coordinate space units). If the number of elements in the array is odd, the elements
        /// of the array get copied and concatenated.
        /// For example, [5, 15, 25] will become [5, 15, 25, 5, 15, 25].
        /// </param>
        public virtual void SetLineDash(uint[] segments)
        {
            return;
        }

        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments">
        /// An Array. A list of numbers that specifies distances to alternately draw a line and a gap
        /// (in coordinate space units). If the number of elements in the array is odd, the elements
        /// of the array get copied and concatenated.
        /// For example, [5, 15, 25] will become [5, 15, 25, 5, 15, 25].
        /// </param>
        public virtual void SetLineDash(int[] segments)
        {
            return;
        }

        /// <summary>
        /// Sets the current line dash pattern.
        /// </summary>
        /// <param name="segments">
        /// An Array. A list of numbers that specifies distances to alternately draw a line and a gap
        /// (in coordinate space units). If the number of elements in the array is odd, the elements
        /// of the array get copied and concatenated.
        /// For example, [5, 15, 25] will become [5, 15, 25, 5, 15, 25].
        /// </param>
        /// <remarks>Use this overload ONLY when you know what you're doing!</remarks>
        public virtual void SetLineDash(string segments)
        {
            return;
        }

        /// <summary>
        /// Specifies where to start a dash array on a line.
        /// </summary>
        public float LineDashOffset;

        #endregion

        /// <summary>
        /// The following properties control how text is laid out.
        /// </summary>
        #region Text Styles

        /// <summary>
        /// Font setting. Default value 10px sans-serif.
        /// </summary>
        public string Font;

        /// <summary>
        /// Text alignment setting. Possible values: start (default), end, left, right or center.
        /// </summary>
        public CanvasTypes.CanvasTextAlign TextAlign;

        /// <summary>
        /// Baseline alignment setting. Possible values: top, hanging, middle, alphabetic (default),
        /// ideographic, bottom.
        /// </summary>
        public CanvasTypes.CanvasTextBaselineAlign TextBaseline;

        /// <summary>
        /// Directionality. Possible values: ltr, rtl, inherit (default).
        /// </summary>
        public CanvasTypes.CanvasTextDirection Direction;

        #endregion

        /// <summary>
        /// Fill styling is used for colors and styles inside shapes and stroke styling is used for
        /// the lines around shapes.
        /// </summary>
        #region Fill and Stroke Styles

        /// <summary>
        /// Color or style to use inside shapes. Default #000 (black).
        /// </summary>
        public string FillStyle;

        /// <summary>
        /// Color or style to use for the lines around shapes. Default #000 (black).
        /// </summary>
        public string StrokeStyle;

        #endregion

        #region Gradients and Patterns
        /// <summary>
        /// Creates a linear gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start point.</param>
        /// <param name="y0">The y axis of the coordinate of the start point.</param>
        /// <param name="x1">The x axis of the coordinate of the end point.</param>
        /// <param name="y1">The y axis of the coordinate of the end point.</param>
        /// <returns>A linear CanvasGradient initialized with the specified line.</returns>
        public virtual CanvasGradient CreateLinearGradient(uint x0, uint y0, uint x1, uint y1)
        {
            return null;
        }

        /// <summary>
        /// Creates a linear gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start point.</param>
        /// <param name="y0">The y axis of the coordinate of the start point.</param>
        /// <param name="x1">The x axis of the coordinate of the end point.</param>
        /// <param name="y1">The y axis of the coordinate of the end point.</param>
        /// <returns>A linear CanvasGradient initialized with the specified line.</returns>
        public virtual CanvasGradient CreateLinearGradient(int x0, int y0, int x1, int y1)
        {
            return null;
        }

        /// <summary>
        /// Creates a linear gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start point.</param>
        /// <param name="y0">The y axis of the coordinate of the start point.</param>
        /// <param name="x1">The x axis of the coordinate of the end point.</param>
        /// <param name="y1">The y axis of the coordinate of the end point.</param>
        /// <returns>A linear CanvasGradient initialized with the specified line.</returns>
        public virtual CanvasGradient CreateLinearGradient(double x0, double y0, double x1, double y1)
        {
            return null;
        }

        /// <summary>
        /// Creates a radial gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start circle.</param>
        /// <param name="y0">The y axis of the coordinate of the start circle.</param>
        /// <param name="r0">The radius of the start circle.</param>
        /// <param name="x1">The x axis of the coordinate of the end circle.</param>
        /// <param name="y1">The y axis of the coordinate of the end circle.</param>
        /// <param name="r1">The radius of the end circle.</param>
        /// <returns>A radial CanvasGradient initialized with the two specified circles.</returns>
        public virtual CanvasGradient CreateRadialGradient(uint x0, uint y0, uint r0, uint x1, uint y1, uint r1)
        {
            return null;
        }

        /// <summary>
        /// Creates a radial gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start circle.</param>
        /// <param name="y0">The y axis of the coordinate of the start circle.</param>
        /// <param name="r0">The radius of the start circle.</param>
        /// <param name="x1">The x axis of the coordinate of the end circle.</param>
        /// <param name="y1">The y axis of the coordinate of the end circle.</param>
        /// <param name="r1">The radius of the end circle.</param>
        /// <returns>A radial CanvasGradient initialized with the two specified circles.</returns>
        public virtual CanvasGradient CreateRadialGradient(int x0, int y0, int r0, int x1, int y1, int r1)
        {
            return null;
        }

        /// <summary>
        /// Creates a radial gradient along the line given by the coordinates represented by the parameters.
        /// </summary>
        /// <param name="x0">The x axis of the coordinate of the start circle.</param>
        /// <param name="y0">The y axis of the coordinate of the start circle.</param>
        /// <param name="r0">The radius of the start circle.</param>
        /// <param name="x1">The x axis of the coordinate of the end circle.</param>
        /// <param name="y1">The y axis of the coordinate of the end circle.</param>
        /// <param name="r1">The radius of the end circle.</param>
        /// <returns>A radial CanvasGradient initialized with the two specified circles.</returns>
        public virtual CanvasGradient CreateRadialGradient(double x0, double y0, double r0, double x1, double y1, double r1)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">
        /// A CanvasImageSource to be used as image to repeat. It can either be a:
        /// • HTMLImageElement (<img>),
        /// • HTMLVideoElement (<video>),
        /// • HTMLCanvasElement (<canvas>),
        /// • CanvasRenderingContext2D,
        /// • ImageBitmap,
        /// • ImageData, or a
        /// • Blob.
        /// </param>
        /// <param name="repetition"></param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        /// <remarks>
        /// At the time of implementation, ImageBitmap had no documentation and Bridge.NET did not have
        /// it defined inside.
        /// </remarks>
        public virtual CanvasPattern CreatePattern(string image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A ImageElement to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(ImageElement image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A VideoElement to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(VideoElement image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A CanvasElement to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(CanvasElement image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A CanvasRenderingContext2D to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(CanvasRenderingContext2D image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A ImageData object to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(ImageData image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        /// <summary>
        /// Creates a pattern using the specified image (a CanvasImageSource). It repeats the source in the
        /// directions specified by the repetition argument. This method returns a CanvasPattern.
        /// </summary>
        /// <param name="image">A Blob to be used as image to repeat.</param>
        /// <param name="repetition">
        /// A CanvasTypes.CanvasRepetitionType indicating how to repeat the image.
        /// If repetition is an empty string ('') or null (but not undefined), repetition will be "repeat".
        /// </param>
        /// <returns>An opaque CanvasPattern object describing a pattern.</returns>
        public virtual CanvasPattern CreatePattern(Blob image, CanvasTypes.CanvasRepetitionTypes repetition)
        {
            return null;
        }

        #endregion

        #region Shadows

        /// <summary>
        /// Specifies the blurring effect. Default 0
        /// </summary>
        public float ShadowBlur;

        /// <summary>
        /// Color of the shadow. Default fully-transparent black.
        /// </summary>
        public string ShadowColor;

        /// <summary>
        /// Horizontal distance the shadow will be offset. Default 0.
        /// </summary>
        public float ShadowOffsetX;

        /// <summary>
        /// Vertical distance the shadow will be offset. Default 0.
        /// </summary>
        public float ShadowOffsetY;

        #endregion

        /// <summary>
        /// The following methods can be used to manipulate paths of objects.
        /// </summary>
        #region Paths

        /// <summary>
        /// Starts a new path by emptying the list of sub-paths. Call this method when you want
        /// to create a new path.
        /// </summary>
        public virtual void BeginPath()
        {
            return;
        }

        // All remaining methods here are inherited from SVGOperations, which are common to the Path2D interface.
        #endregion

        #region Drawing Paths

        /// <summary>
        /// Fills the subpaths with the current fill style.
        /// </summary>
        public virtual void Fill()
        {
            return;
        }

        /// <summary>
        /// Fills the subpaths with the specified fill rule.
        /// </summary>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        public virtual void Fill(CanvasTypes.CanvasFillRule fillRule)
        {
            return;
        }

        /// <summary>
        /// Fills the specified path with the specified fill rule.
        /// </summary>
        /// <param name="path">A Path2D path to fill.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        public virtual void Fill(Path2D path, CanvasTypes.CanvasFillRule fillRule)
        {
            return;
        }

        /// <summary>
        /// Strokes the subpaths with the current stroke style.
        /// </summary>
        public virtual void Stroke()
        {
            return;
        }

        /// <summary>
        /// Strokes the subpaths with the current stroke style.
        /// </summary>
        /// <param name="path">A Path2D path to stroke.</param>
        public virtual void Stroke(Path2D path)
        {
            return;
        }

        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="element">The element to check whether it is focused or not.</param>
        public virtual void DrawFocusIfNeeded(Element element)
        {
            return;
        }

        /// <summary>
        /// If a given element is focused, this method draws a focus ring around the current path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="element">The element to check whether it is focused or not.</param>
        public virtual void DrawFocusIfNeeded(Path2D path, Element element)
        {
            return;
        }

        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void ScrollPathIntoView()
        {
            return;
        }

        /// <summary>
        /// Scrolls the current path or a given path into the view.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void ScrollPathIntoView(Path2D path)
        {
            return;
        }

        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is
        /// called appears inside the clipping path only. For an example, see Clipping paths in
        /// the Canvas tutorial.
        /// </summary>
        public virtual void Clip()
        {
            return;
        }

        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is
        /// called appears inside the clipping path only. For an example, see Clipping paths in
        /// the Canvas tutorial.
        /// </summary>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        public virtual void Clip(CanvasTypes.CanvasFillRule fillRule)
        {
            return;
        }

        /// <summary>
        /// Creates a clipping path from the current sub-paths. Everything drawn after clip() is
        /// called appears inside the clipping path only. For an example, see Clipping paths in
        /// the Canvas tutorial.
        /// </summary>
        /// <param name="path">A Path2D path to clip.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        public virtual void Clip(Path2D path, CanvasTypes.CanvasFillRule fillRule)
        {
            return;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(uint x, uint y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(int x, int y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(double x, double y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(Path2D path, uint x, uint y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(Path2D path, int x, int y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is contained in the current path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <param name="fillRule">
        /// The algorithm by which to determine if a point is inside a path or outside a path.
        /// </param>
        /// <returns>
        /// A Boolean, which is true if the specified point is contained in the current or specfied path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInPath(Path2D path, double x, double y, CanvasTypes.CanvasFillRule? fillRule = null)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(uint x, uint y)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(int x, int y)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(double x, double y)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(Path2D path, uint x, uint y)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(Path2D path, int x, int y)
        {
            return false;
        }

        /// <summary>
        /// Reports whether or not the specified point is inside the area contained by the stroking of a path.
        /// </summary>
        /// <param name="path">A Path2D path to use.</param>
        /// <param name="x">The X coordinate of the point to check.</param>
        /// <param name="y">The Y coordinate of the point to check.</param>
        /// <returns>
        /// A Boolean, which is true if the point is inside the area contained by the stroking of a path,
        /// otherwise false.
        /// </returns>
        public virtual bool IsPointInStroke(Path2D path, double x, double y)
        {
            return false;
        }

        #endregion

        /// <summary>
        /// Objects in the CanvasRenderingContext2D rendering context have a current transformation matrix and methods to manipulate it. The transformation matrix is applied when creating the current default path, painting text, shapes and Path2D objects. The methods listed below remain for historical and compatibility reasons as SVGMatrix objects are used in most parts of the API nowadays and will be used in the future instead.
        /// </summary>
        #region Transformations

        /// <summary>
        /// Current transformation matrix (SVGMatrix object).
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public SVGMatrix CurrentTransform;

        /// <summary>
        /// Adds a rotation to the transformation matrix. The angle argument represents a clockwise rotation angle and is expressed in radians.
        /// </summary>
        public virtual void Rotate()
        {
            return;
        }

        /// <summary>
        /// Adds a scaling transformation to the canvas units by x horizontally and by y vertically.
        /// </summary>
        public virtual void Scale()
        {
            return;
        }

        /// <summary>
        /// Adds a translation transformation by moving the canvas and its origin x horizontally and y vertically on the grid.
        /// </summary>
        public virtual void Translate(uint x, uint y)
        {
            return;
        }

        /// <summary>
        /// Adds a translation transformation by moving the canvas and its origin x horizontally and y vertically on the grid.
        /// </summary>
        public virtual void Translate(double x, double y)
        {
            return;
        }

        /// <summary>
        /// Multiplies the current transformation matrix with the matrix described by its arguments.
        /// </summary>
        public virtual void Transform()
        {
            return;
        }

        /// <summary>
        /// Resets the current transform to the identity matrix, and then invokes the transform() method with the same arguments.
        /// </summary>
        public virtual void SetTransfrom()
        {
            return;
        }

        /// <summary>
        /// Resets the current transform by the identity matrix.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void ResetTransform()
        {
            return;
        }

        #endregion

        #region Composing

        /// <summary>
        /// Alpha value that is applied to shapes and images before they are composited onto the canvas. Default 1.0 (opaque).
        /// </summary>
        public float GlobalAlpha;

        /// <summary>
        /// With globalAlpha applied this sets how shapes and images are drawn onto the existing bitmap.
        /// </summary>
        public CanvasTypes.CanvasCompositeOperationType GlobalCompositeOperation;

        #endregion

        #region Drawing Images

        /// <summary>
        /// Draws the specified image. This method is available in multiple formats, providing a great deal of flexibility in its use.
        /// </summary>
        public virtual void DrawImage()
        {
            return;
        }

        #endregion

        /// <summary>
        /// See also the ImageData object.
        /// </summary>
        #region Pixel Manipulation

        /// <summary>
        /// Creates a new, blank ImageData object with the specified dimensions. All of the pixels in the new object are transparent black.
        /// </summary>
        public virtual void CreateImageData()
        {
            return;
        }

        /// <summary>
        /// Returns an ImageData object representing the underlying pixel data for the area of the canvas denoted by the rectangle which starts at (sx, sy) and has an sw width and sh height.
        /// </summary>
        public virtual void GetImageData()
        {
            return;
        }

        /// <summary>
        /// Paints data from the given ImageData object onto the bitmap. If a dirty rectangle is provided, only the pixels from that rectangle are painted.
        /// </summary>
        public virtual void PutImageData()
        {
            return;
        }

        #endregion

        #region Image Smoothing

        /// <summary>
        /// Image smoothing mode; if disabled, images will not be smoothed if scaled.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public bool ImageSmoothingEnabled;

        #endregion

        /// <summary>
        /// The CanvasRenderingContext2D rendering context contains a variety of drawing style states (attributes for
        /// line styles, fill styles, shadow styles, text styles). The following methods help you to work with that state
        /// </summary>
        #region Canvas State

        /// <summary>
        /// Saves the current drawing style state using a stack so you can revert any change you make to it
        /// using Restore().
        /// </summary>
        public virtual void Save()
        {
            return;
        }

        /// <summary>
        /// Restores the drawing style state to the last element on the 'state stack' saved by save().
        /// </summary>
        public virtual void Restore()
        {
            return;
        }

        /// <summary>
        /// A read-only back-reference to the HTMLCanvasElement.
        /// Might be null if it is not associated with a <canvas> element.
        /// </summary>
        public readonly CanvasElement Canvas;
        #endregion

        #region Hit Regions

        /// <summary>
        /// Adds a hit region to the canvas.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void AddHitRegion()
        {
            return;
        }

        /// <summary>
        /// Removes the hit region with the specified id from the canvas.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void RemoveHitRegion()
        {
            return;
        }

        /// <summary>
        /// Removes all hit regions from the canvas.
        /// </summary>
        /// <remarks>This is experimental API that should not be used in production code.</remarks>
        public virtual void ClearHitRegions()
        {
            return;
        }

        #endregion

        #region Non-standard APIs
        // Non-standard APIs are not implemented on Bridge.NET.

        /// <summary>
        /// Most of these APIs are deprecated and will be removed in the future.
        /// </summary>
        #endregion
    }
}
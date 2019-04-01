using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.Text.Editor
{
	public interface ITextViewFactoryService
	{
		ITextView CreateTextView (ITextBuffer buffer);

		ITextView CreateTextView ();
	}
}

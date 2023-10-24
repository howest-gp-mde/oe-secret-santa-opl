using Xamarin.Forms;

namespace Mde.SecretSanta.Behaviors
{
    public class ColorBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            if (entry.Text.Length <= 3) entry.TextColor = Color.Red;
            else entry.TextColor = Color.Green;
        }
    }
}

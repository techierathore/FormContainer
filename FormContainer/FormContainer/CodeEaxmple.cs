
using Xamarin.Forms;

namespace FormContainer
{
    public class CodeEaxmple : ContentPage
    {
        public CodeEaxmple()
        {
            Padding = new Thickness(0,10,0,10);
            Title = "Code Example";
            var vContentStack = new StackLayout
            {
                Children = {
                    new Label { Text = "Name : S Ravi Kumar", TextColor=Color.Red },
                     new Label { Text = "Place : India", TextColor=Color.Red },
                      new Label { Text = "Twitter : @srkrathore", TextColor=Color.Red },
                       new Label { Text = "Blog : http://err2solution.com/", TextColor=Color.Red },
                }
            };
            var vFormContainer = new MyContainer() {
                HeaderText = "My Details (Code)",
                HeaderTextColor = Color.Red,
                HeaderBackGroundColor= Color.Gray,
                ContentBackgroundColor = Color.White,
                ContainerContent = vContentStack
            };
            Content = vFormContainer;
        }
    }
}

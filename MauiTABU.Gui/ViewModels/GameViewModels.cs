using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTABU.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTABU.Gui.ViewModels
{
    public partial class GameViewModels : ObservableObject
    {


        private List<Card> _cards= new List<Card>();

        [ObservableProperty]
        private Card _card = null;


        [RelayCommand]
        void LoadCards()
        {
            CardGenerator cardGenerator = new CardGenerator();
        }
    }
}

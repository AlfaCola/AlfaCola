   M S B A M L   `   `   `  ????V  RЯзыковая школа, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:Языковая_школа.PageGuest%Языковая_школа.PageGuest  5      9    3Языковая_школа.PageGuest.PageMainGuest   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Elocal3clr-namespace:Языковая_школа.PageGuest     5        N? Title$1  +Предоставляемые услуги??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??0.15* ?6   ?? 5      $
??0.7* ?6   ?? 5      $??0.15* ?6   .+?5   
   ?? $
??Left=?6    ?? Orientation$ 
Horizontal=?60   $??Center=?6I   .+?5      ??    TextBlockAll#??[  6   $??Сорт. по цене??6>   $??Center=?6S   $??Center=?6p   $??20(?6?   $	??150??6?   ?? 5      -   5        $??
SortPoCene??5      $??Center=?6)   $??Center=?6F   $??5q?6a    d? 	IsChecked 6l   Z? 6?   ?? 5      -   5        $??Skidki??5   C   $	??120??6Q   $??30??6]   $??5q?6i   .@?5      ?? $
??0-5%??6   ?? 5      $??5-15%??6   ?? 5      $??15-30%??6   ?? 5      $??30-70%??6   ?? 5      $??70-100%??6   5      ?? 5      -   5         ??Name$ Sbros??5        ButtonchikAll#??[ 68   $??60??6_   $??
Сброс??6j   ?? 5      #??[  6   $??
Поиск??6>   $??Center=?6K   $??Center=?6h   $??20(?6?   $??70??6?   ?? 5      -   5         ??Name$ Poisk??5        
TextBoxAll#??[ 6E   5      ?? 5   
   -   5        $
 Back??5        ButtonchikAdminDelete#??[ 62   $??5q?6a   $??Right=?6l   $??
Назад??6?   $??20(?6?   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ SpisokYslus??5    h   $??Stretch=?6   $??Stretch=?61   $??Comic Sans MS)?6M   $??1??6}      AutoGenerateColumns .     Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Наименование??6?   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Title+6U     5#      $	 Цена??6>   $
 * 6L    6%   ?? *Cost+6L     5$      $(	 "Продолжительность??6K   $
 * 6f    6%   ?? *DurationInSeconds+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5%      $	 Изображение??6)   $
 * 6>      CellTemplate 5&      ?? 5'      .R?5(      ?? ??6$   ?? *MainImagePath+5)      5+        5,      $	 Скидка??6B   $
 * 6R    6%   ?? *
Discount+6R   5.      ?? 5/   
   $??2??6   $ 
Horizontal=?6"   $
??Left=?6;   $??Center=?6V   .+?50      ?? -   5         ??Name$ SkolkoZapisey??50      #??[  6/   $	??300??6U   $??Right=?6a   $??Center=?6}   51      52      53      
   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      *    $Presentation.Views.AddDiscussionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  	AdminView��5	       � DataContext 5      4   .Presentation.ViewModels.AddDiscussionViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $( "..\Views\Resource\Style\Forum.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��235* �6   �� 5      $
��323* �6   �� 5      $
��242* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��91* �6   �� 5      $
��132* �6   �� 5      $
��187* �6   .+�5   
   �� $��0��6   $��3��6   $��Обсуждение��61   $��Stretch=�6F   $��Stretch=�6d   �� 5    
   $��1��6   $��0��6!   $��Название:��61   $��18(�6B   $��Center=�6P   $��Center=�6k   �� 5!   
   $��1��6   $��1��6   $��0,37,0,0q�6/   ��6A   �� *DiscussionName+ �� Mode$ TwoWay=�.��6n    � ToolTip$I CТекст не должен начинаться с пробела��5"   T   .��5#      �� 5$   
   $��2��6   $��0��6!   $��Текст:��61   $��18(�6?   $��Center=�6M   $��Center=�6h   �� 5%   
   $��2��6   $��1��6   $��0,50,0,0q�6/   ��6A   �� *DiscussionText+$ TwoWay=�.��6n   $I CТекст не должен начинаться с пробела��5&   T   .��5'      �� 5(   
   $��3��6   $��2��6   $+��%Добавить обсуждение��62   $	��254��6P   $��51��6\   ��6h   �� *AddDiscussionCommand+�� 5)   
   $��2��6   $��3��6!   $��
Тесты��6.   $��	0,122,0,0q�6b   $	��Top=�6u   ��6>   �� *GoToTestCommand+6u   �� 5*   
   $��2��6   $��3��6!   $��
Форум��6.   $��0,58,0,0q�6c   $	��Top=�6u   ��6>   �� *GoToForumCommand+6u   �� 5+   
   $��2��6   $��2��6!   $)��#Удалить обсуждение��6.   $��Center=�6w   ��6K   �� *RemoveDiscussionCommand+6w   �� 5,   
   $��2��6   $��2��6!   $'��!Удалить сообщение��6.   $	��Top=�6J   $��	0,115,0,0q�6b   $��2��6u   ��6�   �� *RemoveMessageCommand+�� 5-   
   $��2��6   $��3��6    $%��..\Views\Resource\Image\Add.png��61   $��15,16,31,94q�6Z   5.      5/      
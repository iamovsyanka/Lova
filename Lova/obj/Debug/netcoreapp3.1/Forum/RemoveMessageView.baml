   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      *    $Presentation.Views.RemoveMessageView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  	AdminView��5	       � DataContext 5      4   .Presentation.ViewModels.RemoveMessageViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $( "..\Views\Resource\Style\Forum.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��235* �6   �� 5      $
��323* �6   �� 5      $
��242* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��126* �6   �� 5      $	��97* �6   �� 5      $
��187* �6   .+�5   
   �� $��1��6   $��0��6    $��2��60   $��2��6D   ��6U   �� *
Messages+ �� SelectedItem 6v   �� *SelectedMessage+��5       �� 5!      .R�5"      �� .+�5#      �� ���#8570E0$��1q�67   $	��505��6K   ._�5$      �� .+�5%   "   �� $��14(�6F   ��6,   �� *
UserName+6F   �� 5&   "   $
��Bold"�6B   $��16(�6T   $
��Wrap=�6b   ��6,   �� *Text+6b   �� 5'   "   $��14(�6B   $
��Wrap=�6P   ��6,   �� *When+6P   5(      5)      5*      5+      5-      �� 5.   
   $��0��6   $��3��6   $��Сообщения��61   �� 5/   
   $��2��6   $��1��6    $��2��6-   $(��"..\Views\Resource\Image\Remove.png��6>   �� 50   
   $��3��6   $��2��6   $'��!Удалить сообщение��62   $	��254��6N   $��51��6Z   ��6f   �� *RemoveMessageCommand+�� 51   
   $��2��6   $��3��6!   $��
Тесты��6.   $��	0,100,0,0q�6b   $	��Top=�6u   $��40��6�   $	��170��6�   ��6>   �� *GoToTestCommand+6�   �� 52   
   $��2��6   $��3��6!   $��
Форум��6.   $��0,24,0,0q�6c   $	��Top=�6u   $��40��6�   $	��170��6�   ��6>   �� *GoToForumCommand+6�   53      54      
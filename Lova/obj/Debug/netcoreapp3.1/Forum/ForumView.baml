   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      "    Presentation.Views.ForumView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  Forum��5	       � DataContext 5      ,   &Presentation.ViewModels.ForumViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $( "..\Views\Resource\Style\Forum.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��551* �6   �� 5      $
��249* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��56* �6   �� 5      $	��58* �6   �� 5      $
��128* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��35* �6   .+�5!   
   �� $��0��6   $��0��6   $��2��6-   $��
Форум��6A   � 5"   
   $��1��6   $��7��6   $��0��6-   .+�5#      �� ��6   �� *Discussions+ �� SelectedItem 6;   �� *SelectedDiscussion+��5$      �� 5%      .R�5&      �� .+�5'      �� ���#8570E0$��1q�6;   $	��575��6O   ._�5(   "   �� .+�5)   &   �� $
��Bold"�6P   $��16(�6b   $��Center=�6p   ��60   �� *DiscussionName+6p   �� 5*   &   $��14(�6F   $
��Wrap=�6T   ��60   �� *Text+6T   �� 5+   &   $H��BНажмите ❤, чтобы выбрать обсуждение��60   $	��289��6[   $��22��6g   $��Right=�6s   �� 5,   &   .+�5-   *   �� $	��500��6T   $	��153��6`   ��63   �� *
Messages+��5.   .   �� 5/   2   .R�50   6   �� ���#7FDACD$	��463��6V   .+�51   :   �� ._�52   >   �� .+�53   B   ��  �� Orientation$ 
Horizontal=�6M   .+�54   F   �� $
��Bold"�6j   $��13(�6|   ��6P   �� *
UserName+6|   �� 55   F   $�� (��6P   �� 56   F   $��13(�6f   ��6P   �� *When+6f   �� 57   F   $��):��6P   58   C   �� 59   B   .+�5:   F   �� $��15(�6f   $��WrapWithOverflow=�6t   ��6P   �� *Text+6t   5;   C   5<   ?   5=   ;   5>   7   5?   3   5A   +   5B   '   5C   #   5D      5E      5F      5H      5I      �� 5J   
   $��1��6   $��1��6   $��
18,0,18,10q�6L   ��6/   �� *MessageText+.��6a    � ToolTip$I CТекст не должен начинаться с пробела��5K   T   .��5L      �� 5M   
   $��1��6   $��2��6!   $+��%Отправить сообщение��6U   $��40��6s   $	��170��6   ��6.   �� *SendMessageCommand+6   �� 5N   
   $��3��6   $��1��6   $)��#..\Views\Resource\Image\NewPage.png��6-    5O      �� 5P      ��6   �� *	Tooltip+5R      �� 5S   
   $��1��6   $��5��6!   $��
Тесты��6.   $��40��6b   ��6>   �� *GoToTestCommand+6b   �� 5T   
   $��1��6   $��4��6!   $ ��Администратор��6.   $��40��6o   ��6F   �� *AddDiscussionCommand+6o   �� 5U   
   $��1��6   $��6��6!   $��Калькулятор��6.   $��40��6n   ��6D   �� *GoToCalculatorCommand+6n   5V      5W      
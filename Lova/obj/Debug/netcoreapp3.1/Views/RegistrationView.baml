   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5   	   )    #Presentation.Views.RegistrationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   .vm%clr-namespace:Presentation.ViewModels  5   	     N� Title$  Registration��5	   	   $	��500��5
   	   $	��500��6    � DataContext 5      3   -Presentation.ViewModels.RegistrationViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $% Resource\Style\StartWindow.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $	��93* �6   �� 5      $
��224* �6   �� 5      $	��93* �6    � RowDefinitions 5   
   �� 5      $
��149* �6   �� 5      $	��68* �6   �� 5      $	��68* �6   �� 5      $	��68* �6   �� 5      $	��78* �6   �� 5      $	��68* �6   .+�5"   
   �� $��1��6   $��0��6    ��6-   �� *Img+�� 5#   
   $��0��6   $��1��6    $��Resource/Icons/Login.ico��6-   $��
53,13,7,10q�6O    � ToolTip 5$      _� 5%       _� 	Placement$
 Left=�6   .��6+   LJЛогин должен содержать больше 4 символов6U   5'      �� 5(   
   $��0��6   $��2��6    $!��Resource/Icons/Password.ico��6-   $��
53,13,7,10q�6R    5)      _� 5*      $
 Left=�6   $U��OПароль должен содержать не менее 6 символов��6+   5,      �� 5-   
   $��1��6   $��1��6"   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6/    %  !MaterialDesignFloatingHintTextBox#��[  6V   $��45��6�   	 �� TextWrapping$
	 Wrap=�6�   $��18(�6�   $
��Bold"�6�   
 �� 
CaretBrush
 �	#FF2CB4A2.��6�   ��5.      �� 5/       �� Path$ UserName�6    �� UpdateSourceTrigger$ PropertyChanged=�6*    �� ValidatesOnDataErrors$
 True��6P    �� ValidationRules 50      5  /System.Windows.Controls.ExceptionValidationRule  51      53      .��54      55      G� 56   
   -   5        $��1��56      $��2��6&   $ Пароль��63    ) %MaterialDesignFloatingHintPasswordBox#��[ 6�   $��18(�6�   $
��Bold"�6�    G� 
CaretBrush �	#FF2CB4A26�   G� 57   
   -   5        $��1��57      $��3��6&   $% Повторите пароль��63   #��[ 6�   $��18(�6�   $
��Bold"�6�    �	#FF2CB4A26�   �� 58   
   $��1��6   $��4��6!   $*��$Зарегистрироваться��6.   ��6K   �� *SignUpCommand+�� 59   
   $��5��6   $��1��6!   $	��Top=�61   Есть аккаунт? �� 5:      ���	#FF020A11$
��Bold"�6b    �� Command 6&   �� *GoToLoginCommand+.�6t   Авторизация6�   5;      5<      5=      
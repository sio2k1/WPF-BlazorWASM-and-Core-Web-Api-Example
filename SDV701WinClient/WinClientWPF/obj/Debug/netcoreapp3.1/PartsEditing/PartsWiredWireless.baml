   M S B A M L   `   `   `  ����G  CWinClientWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WinClientWPFWinClientWPF  5      %    WinClientWPF.PartsWiredWireless   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WinClientWPF     5      $��72��5      $	��559��6+   $
��Left=�67   $	��Top=�6R   .��5      � $��10,10,10,10q�6   .+�5	   
   �� -   5          ��Name$
  lbl1��5	      $��Ethernet port type:��6   $
��Left=�6<   $	��Top=�6W   $	��155��6o   �� 5
   
   -   5         ��Name$ tbEthernetPortType��5
      $
��Left=�6.   $��0,26,0,0q�6I    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��162��6�   ��6[   �� *EthernetPortType+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ tbEthernetPortNumber��5      $
��Left=�60   $��
167,26,0,0q�6K   $
 Wrap=�6�   $	��Top=�6�   $	��160��6�   ��6_   �� *NumberOfPorts+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $  	lbl1_Copy��5      $��Ethernet port number:��6#   $
��Left=�6C   $��	167,0,0,0q�6^   $	��Top=�6q   $	��155��6�   �� 5   
   $��Wi-Fi standard:��6   $
��Left=�6*   $	��Top=�6E   $	��146��6]   $��	332,0,0,0q�6i   �� 5   
   -   5        $ tbWiFiStandard��5      $
��Left=�6*   $��
332,26,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��201��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6E   �� *WiFiStandard+$ TwoWay=�$ PropertyChanged=�6�   5      5      
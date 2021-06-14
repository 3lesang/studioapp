
### Mo hinh quan he
![Screenshot](erd.jpg)

Luu y
Thay doi Data Source thanh ten server trong may.
### App.config
```
<connectionStrings>
      <add name="cnStr"
           connectionString="Data Source=SANG\SQLEXPRESS;Initial Catalog=FilmDB;Integrated Security=SSPI"
           providerName="System.Data.SqlClient"/>
</connectionStrings>
```
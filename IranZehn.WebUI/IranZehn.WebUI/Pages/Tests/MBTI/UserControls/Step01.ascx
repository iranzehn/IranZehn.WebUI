<%@ Control Language="VB" AutoEventWireup="false" CodeBehind="Step01.ascx.vb" Inherits="IranZehn.Pages.Tests.MBTI.UserControls.Step01" %>

<table style="width: 90%; color: black; font-family: tahoma">


    <tr>
        <td style="width: 90%; height: 21px; font-size: large; font-weight: bold;">آزمون MBTI</td>
    </tr>
    <tr>
        <td style="width: 90%; height: 21px">در جهت یاری در امر غنی سازی پایگاه آماری لطفا قبل از شروع آزمون موارد زیر را تکمیل
            نمایید</td>
    </tr>
    <tr>
        <td>---------------------------------------------------------------------------------------------------------</td>
    </tr>
    <tr>
        <td>تاریخ تولدسال
            <asp:DropDownList ID="ddlYear" runat="server">
                <asp:ListItem Value="-1">----</asp:ListItem>
                <asp:ListItem Value="1300">1300</asp:ListItem>
                <asp:ListItem Value="1301">1301</asp:ListItem>
                <asp:ListItem Value="1302">1302</asp:ListItem>
                <asp:ListItem Value="1303">1303</asp:ListItem>
                <asp:ListItem Value="1304">1304</asp:ListItem>
                <asp:ListItem Value="1305">1305</asp:ListItem>
                <asp:ListItem Value="1306">1306</asp:ListItem>
                <asp:ListItem Value="1307">1307</asp:ListItem>
                <asp:ListItem Value="1308">1308</asp:ListItem>
                <asp:ListItem Value="1309">1309</asp:ListItem>
                <asp:ListItem Value="1310">1310</asp:ListItem>
                <asp:ListItem Value="1311">1311</asp:ListItem>
                <asp:ListItem Value="1312">1312</asp:ListItem>
                <asp:ListItem Value="1313">1313</asp:ListItem>
                <asp:ListItem Value="1314">1314</asp:ListItem>
                <asp:ListItem Value="1315">1315</asp:ListItem>
                <asp:ListItem Value="1316">1316</asp:ListItem>
                <asp:ListItem Value="1317">1317</asp:ListItem>
                <asp:ListItem Value="1318">1318</asp:ListItem>
                <asp:ListItem Value="1319">1319</asp:ListItem>
                <asp:ListItem Value="1320">1320</asp:ListItem>
                <asp:ListItem Value="1321">1321</asp:ListItem>
                <asp:ListItem Value="1322">1322</asp:ListItem>
                <asp:ListItem Value="1323">1323</asp:ListItem>
                <asp:ListItem Value="1324">1324</asp:ListItem>
                <asp:ListItem Value="1325">1325</asp:ListItem>
                <asp:ListItem Value="1326">1326</asp:ListItem>
                <asp:ListItem Value="1327">1327</asp:ListItem>
                <asp:ListItem Value="1328">1328</asp:ListItem>
                <asp:ListItem Value="1329">1329</asp:ListItem>
                <asp:ListItem Value="1330">1330</asp:ListItem>
                <asp:ListItem Value="1331">1331</asp:ListItem>
                <asp:ListItem Value="1332">1332</asp:ListItem>
                <asp:ListItem Value="1333">1333</asp:ListItem>
                <asp:ListItem Value="1334">1334</asp:ListItem>
                <asp:ListItem Value="1335">1335</asp:ListItem>
                <asp:ListItem Value="1336">1336</asp:ListItem>
                <asp:ListItem Value="1337">1337</asp:ListItem>
                <asp:ListItem Value="1338">1338</asp:ListItem>
                <asp:ListItem Value="1339">1339</asp:ListItem>
                <asp:ListItem Value="1340">1340</asp:ListItem>
                <asp:ListItem Value="1341">1341</asp:ListItem>
                <asp:ListItem Value="1342">1342</asp:ListItem>
                <asp:ListItem Value="1343">1343</asp:ListItem>
                <asp:ListItem Value="1344">1344</asp:ListItem>
                <asp:ListItem Value="1345">1345</asp:ListItem>
                <asp:ListItem Value="1346">1346</asp:ListItem>
                <asp:ListItem Value="1347">1347</asp:ListItem>
                <asp:ListItem Value="1348">1348</asp:ListItem>
                <asp:ListItem Value="1349">1349</asp:ListItem>
                <asp:ListItem Value="1350">1350</asp:ListItem>
                <asp:ListItem Value="1351">1351</asp:ListItem>
                <asp:ListItem Value="1352">1352</asp:ListItem>
                <asp:ListItem Value="1353">1353</asp:ListItem>
                <asp:ListItem Value="1354">1354</asp:ListItem>
                <asp:ListItem Value="1355">1355</asp:ListItem>
                <asp:ListItem Value="1356">1356</asp:ListItem>
                <asp:ListItem Value="1357">1357</asp:ListItem>
                <asp:ListItem Value="1358">1358</asp:ListItem>
                <asp:ListItem Value="1359">1359</asp:ListItem>
                <asp:ListItem Value="1360">1360</asp:ListItem>
                <asp:ListItem Value="1361">1361</asp:ListItem>
                <asp:ListItem Value="1362">1362</asp:ListItem>
                <asp:ListItem Value="1363">1363</asp:ListItem>
                <asp:ListItem Value="1364">1364</asp:ListItem>
                <asp:ListItem Value="1365">1365</asp:ListItem>
                <asp:ListItem Value="1366">1366</asp:ListItem>
                <asp:ListItem Value="1367">1367</asp:ListItem>
                <asp:ListItem Value="1368">1368</asp:ListItem>
                <asp:ListItem Value="1369">1369</asp:ListItem>
                <asp:ListItem Value="1370">1370</asp:ListItem>
                <asp:ListItem Value="1371">1371</asp:ListItem>
                <asp:ListItem Value="1372">1372</asp:ListItem>
                <asp:ListItem Value="1373">1373</asp:ListItem>
                <asp:ListItem Value="1374">1374</asp:ListItem>
                <asp:ListItem Value="1375">1375</asp:ListItem>
                <asp:ListItem Value="1376">1376</asp:ListItem>
                <asp:ListItem Value="1377">1377</asp:ListItem>
                <asp:ListItem Value="1378">1378</asp:ListItem>
                <asp:ListItem Value="1379">1379</asp:ListItem>
                <asp:ListItem Value="1380">1380</asp:ListItem>
                <asp:ListItem Value="1381">1381</asp:ListItem>
                <asp:ListItem Value="1382">1382</asp:ListItem>
                <asp:ListItem Value="1383">1383</asp:ListItem>
                <asp:ListItem Value="1384">1384</asp:ListItem>
                <asp:ListItem Value="1385">1385</asp:ListItem>
                <asp:ListItem Value="1386">1386</asp:ListItem>
                <asp:ListItem Value="1387">1387</asp:ListItem>
                <asp:ListItem Value="1388">1388</asp:ListItem>
                <asp:ListItem Value="1389">1389</asp:ListItem>
                <asp:ListItem Value="1390">1390</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp; &nbsp; ماه
            <asp:DropDownList ID="ddlMonth" runat="server">
                <asp:ListItem Value="-1">----</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="6">6</asp:ListItem>
                <asp:ListItem Value="7">7</asp:ListItem>
                <asp:ListItem Value="8">8</asp:ListItem>
                <asp:ListItem Value="9">9</asp:ListItem>
                <asp:ListItem Value="10">10</asp:ListItem>
                <asp:ListItem Value="11">11</asp:ListItem>
                <asp:ListItem Value="12">12</asp:ListItem>
            </asp:DropDownList>
            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; روز
            <asp:DropDownList ID="ddlDay" runat="server">
                <asp:ListItem Value="-1">----</asp:ListItem>
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5">5</asp:ListItem>
                <asp:ListItem Value="6">6</asp:ListItem>
                <asp:ListItem Value="7">7</asp:ListItem>
                <asp:ListItem Value="8">8</asp:ListItem>
                <asp:ListItem Value="9">9</asp:ListItem>
                <asp:ListItem Value="10">10</asp:ListItem>
                <asp:ListItem Value="11">11</asp:ListItem>
                <asp:ListItem Value="12">12</asp:ListItem>
                <asp:ListItem Value="13">13</asp:ListItem>
                <asp:ListItem Value="14">14</asp:ListItem>
                <asp:ListItem Value="15">15</asp:ListItem>
                <asp:ListItem Value="16">16</asp:ListItem>
                <asp:ListItem Value="17">17</asp:ListItem>
                <asp:ListItem Value="18">18</asp:ListItem>
                <asp:ListItem Value="19">19</asp:ListItem>
                <asp:ListItem Value="20">20</asp:ListItem>
                <asp:ListItem Value="21">21</asp:ListItem>
                <asp:ListItem Value="22">22</asp:ListItem>
                <asp:ListItem Value="23">23</asp:ListItem>
                <asp:ListItem Value="24">24</asp:ListItem>
                <asp:ListItem Value="25">25</asp:ListItem>
                <asp:ListItem Value="26">26</asp:ListItem>
                <asp:ListItem Value="27">27</asp:ListItem>
                <asp:ListItem Value="28">28</asp:ListItem>
                <asp:ListItem Value="29">29</asp:ListItem>
                <asp:ListItem Value="30">30</asp:ListItem>
                <asp:ListItem Value="31">31</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="height: 22px">جنسیت &nbsp;<asp:RadioButton ID="rbMan" runat="server" GroupName="sex" Text="مرد" />
            &nbsp; &nbsp;&nbsp;
            <asp:RadioButton ID="rbWoman" runat="server" GroupName="sex" Text="زن" />
        </td>
    </tr>
    <tr>
        <td style="height: 22px">تاهل &nbsp; &nbsp;
            <asp:RadioButton ID="rbSingle" runat="server" GroupName="Maried" Text="مجرد" />
            &nbsp; &nbsp;
            <asp:RadioButton ID="rbMaried" runat="server" GroupName="Maried" Text="متاهل" />
        </td>
    </tr>
    <tr>
        <td>میزان تحصیلات&nbsp;<asp:DropDownList ID="ddlGraduation" runat="server" Style="font-family: tahoma"
            Width="136px">
            <asp:ListItem Value="-1">-----------------</asp:ListItem>
            <asp:ListItem Value="0">زیر دیپلم</asp:ListItem>
            <asp:ListItem Value="1">دیپلم</asp:ListItem>
            <asp:ListItem Value="2">فوق دیپلم</asp:ListItem>
            <asp:ListItem Value="3">لیسانس</asp:ListItem>
            <asp:ListItem Value="4">فوق لیسانس</asp:ListItem>
            <asp:ListItem Value="5">دکترا</asp:ListItem>
            <asp:ListItem Value="6">بالای دکترا</asp:ListItem>
        </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td></td>
    </tr>
    <tr>
        <td style="height: 26px">&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red" Text="خطا" Visible="False"></asp:Label>
            <br />
        </td>
    </tr>
</table>


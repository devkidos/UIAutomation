$(document).ready(function () {
    $("#CheckAllSitesLogin").click(function () {
        TestFeature('/UIAutomation/Home/Google', 'GoogleSuccess', 'GoogleFail', 'GoogleLoader'); 
    });

    $("#Googlepage").click(function () {
        TestFeature('/UIAutomation/Home/Google', 'GoogleSuccess', 'GoogleFail', 'GoogleLoader');
    });
 
});
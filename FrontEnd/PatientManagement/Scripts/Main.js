var globalVars = {},
    patientType = {},
    baseURL = "http://localhost:65105/";

function initSystem() {
    globalVars = {
        isLoggedIn: false,
        userName: null
    };
    patientType = {
        NEW_PATIENT : 0,
        EXISTING_PATIENT : 1
    };
}
    function selectUserAction(type) {  
        if (type === patientType.NEW_PATIENT) {
            window.location = baseURL + "addNewUser.HTML";
        }
        else if (type === patientType.EXISTING_PATIENT) {
            window.location = baseURL + "searchUserInfo.HTML";
        }
        else{
            return;
        }
    }
    $(document).ready(function () {
        initSystem();
    });
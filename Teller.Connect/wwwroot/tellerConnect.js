function launchTellerConnect(callbackObject, environment, applicationId, products) {
    const tellerConnect = TellerConnect.setup({
        environment: environment,
        applicationId: applicationId,
        products: products,

        onSuccess: function (enrollment) {
            callbackObject.invokeMethodAsync("OnSuccess", enrollment);
        }
    });

    tellerConnect.open();
}

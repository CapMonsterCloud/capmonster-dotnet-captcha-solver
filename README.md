# Zennolab.CapMonsterCloud.Client

Official C# client library for [capmonster.cloud](https://capmonster.cloud/) captcha recognition service

## Installation

Via Package Manager:

    Install-Package Zennolab.CapMonsterCloud.Client

Via .NET CLI

    dotnet add package Zennolab.CapMonsterCloud.Client

## Usage

    var clientOptions = new ClientOptions
    {
        ClientKey = "<your capmonster.cloud API key>"
    };

    var cmCloudClient = CapMonsterCloudClientFactory.Create(clientOptions);

    // solve RecaptchaV2 (without proxy)
    var recaptchaV2Request = new RecaptchaV2Request
    {
        WebsiteUrl = "https://lessons.zennolab.com/captchas/recaptcha/v2_simple.php?level=high",
        WebsiteKey = "6Lcg7CMUAAAAANphynKgn9YAgA4tQ2KI_iqRyTwd",
    };
    var recaptchaV2Result = await cmCloudClient.SolveAsync(recaptchaV2Request);

    // solve RecaptchaV2 (with proxy)
    var recaptchaV2ProxyRequest = new RecaptchaV2Request
    {
        WebsiteUrl = "https://lessons.zennolab.com/captchas/recaptcha/v2_simple.php?level=high",
        WebsiteKey = "6Lcg7CMUAAAAANphynKgn9YAgA4tQ2KI_iqRyTwd",
        Proxy = new ProxyContainer("203.0.113.45", 8080, ProxyType.Http, "login", "password")
    };
    var recaptchaV2ProxyResult = await cmCloudClient.SolveAsync(recaptchaV2ProxyRequest);

    // solve a CustomTask (anti-bot/WAF systems such as Tspd, Castle, DataDome, etc.)
    var tspdRequest = new TspdCustomTaskRequest(
        tspdCookie: "TS386a400d029=08...010245; TS386a400d029=08...01a06e; TS386a400d078=08...dbb3b0c; TSd2153684027=08...1944",
        htmlPageBase64: "PCFET0NU...k+PC9odG1sPg==")
    {
        WebsiteUrl = "https://yourwebsite.com/page-with-tspd",
        Proxy = new ProxyContainer("203.0.113.45", 8080, ProxyType.Http, "login", "password")
    };
    var tspdResult = await cmCloudClient.SolveAsync(tspdRequest);

Supported captcha recognition requests:

Classic captcha tasks:

- [AmazonWafRequest](https://zenno.link/doc-amazon-waf)
- [BinanceTaskRequest](https://zenno.link/doc-binance)
- [FunCaptchaRequest](https://zenno.link/doc-funcaptcha)
- [GeeTestRequest](https://zenno.link/doc-geetest)
- [ImageToTextRequest](https://zenno.link/doc-imagetotext)
- [MTCaptchaTaskRequest](https://zenno.link/doc-mtcaptcha)
- [ProsopoTaskRequest](https://zenno.link/doc-prosopo)
- [RecaptchaV2Request](https://zenno.link/doc-recaptcha2)
- [RecaptchaV2EnterpriseRequest](https://zenno.link/doc-recaptcha2e)
- [RecaptchaV3ProxylessRequest](https://zenno.link/doc-recaptcha3)
- [TurnstileRequest - Cloudflare Turnstile](https://zenno.link/doc-cloudflare-turnstile)
- [TurnstileRequest - Cloudflare Challenge](https://zenno.link/doc-cloudflare-challenge)
- [TurnstileRequest - Cloudflare Waiting Room](https://zenno.link/doc-cloudflare-waitingroom)
- [YidunTaskRequest](https://zenno.link/doc-yidun)

Custom tasks (anti-bot / WAF / custom challenge systems):

- [AlibabaCustomTaskRequest](https://zenno.link/doc-customtask-alibaba)
- [AltchaCustomTaskRequest](https://zenno.link/doc-customtask-altcha)
- [BasiliskCustomTaskRequest](https://zenno.link/doc-customtask-basilisk)
- [DataDomeCustomTaskRequest](https://zenno.link/doc-customtask-datadome)
- [FriendlyCustomTaskRequest](https://zenno.link/doc-customtask-friendly)
- [HuntCustomTaskRequest](https://zenno.link/doc-customtask-hunt)
- [ImpervaCustomTaskRequest](https://zenno.link/doc-customtask-imperva)
- [TenDiCustomTaskRequest](https://zenno.link/doc-customtask-tendi)
- [TspdCustomTaskRequest](https://zenno.link/doc-customtask-tspd)

Complex image tasks (grid / dynamic image selection tasks):

- [RecaptchaComplexImageTaskRequest](https://zenno.link/doc-complextask-rc)
- [RecognitionComplexImageTaskRequest](https://zenno.link/doc-complextask-recognition)

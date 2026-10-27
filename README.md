# CapMonster Cloud .NET SDK: C# Captcha Solver & Captcha Bypass for reCAPTCHA, Cloudflare Turnstile and GeeTest

> **🔄 Migrating from 2Captcha or Capsolver?** CapMonster Cloud is a fast, cost-effective **2captcha alternative** and **capsolver alternative** for .NET and .NET: reCAPTCHA v3 from **$0.90 per 1,000 solves**, which is **up to 38% cheaper than 2Captcha** and **10% cheaper than Capsolver**, with an API response time of **≤ 2 s**. Already have software built for 2Captcha? CapMonster Cloud [supports the 2Captcha API format](https://docs.capmonster.cloud/docs/external-services/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme). Moving your .NET code takes just a few lines: see the **Migration examples** below. Full comparison and disclaimer are in the comparison section below.

[![CapMonster Cloud .NET SDK - captcha solver and captcha bypass API client](https://img.shields.io/badge/CapMonster%20Cloud-.NET%20Captcha%20Solver-00B2FF?style=for-the-badge&logo=dotnet&logoColor=white)](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)

**Official asynchronous C# / .NET client for automated CAPTCHA solving in web scraping, browser automation, and testing workflows.**

[![NuGet Version](https://img.shields.io/nuget/v/Zennolab.CapMonsterCloud.Client.svg?style=flat-square&color=blue)](https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Zennolab.CapMonsterCloud.Client.svg?style=flat-square&color=green)](https://www.nuget.org/packages/Zennolab.CapMonsterCloud.Client/)
[![GitHub Stars](https://img.shields.io/github/stars/CapMonsterCloud/capmonster-dotnet-captcha-solver?style=flat-square&color=yellow)](https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/CapMonsterCloud/capmonster-dotnet-captcha-solver?style=flat-square)](https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/network/members)
[![License: MIT](https://img.shields.io/badge/License-MIT-orange.svg?style=flat-square)](https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/blob/main/LICENSE)

---

Official .NET client library for [CapMonster Cloud](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme). Integrate automated CAPTCHA recognition into **C#, ASP.NET, WPF, Selenium, and browser automation** projects using an asynchronous API client. As the official CapMonster SDK for .NET, it is a cost-effective 2captcha alternative and capsolver alternative.

Use the SDK for captcha bypass with popular CAPTCHA and anti-bot task types, including **reCAPTCHA v2/v3/Enterprise, Cloudflare Turnstile, GeeTest, DataDome, Amazon WAF, Imperva, and image-to-text tasks**.

**[👉 Get your Free API Key & Free Trial Balance on CapMonster Cloud](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)**

---

## ⚡ Highlights

- ⚡ **Fast solving:** AI-based recognition, on average between 1 and 30 seconds depending on the captcha type.
- 🤖 **Zero human workers:** 100% automated machine learning pipeline with no manual latencies.
- 🛡️ **Modern anti-bot bypass:** Full support for Cloudflare Turnstile, reCAPTCHA Enterprise, GeeTest, DataDome, Amazon WAF and Imperva.
- ⚡ **Async-first API:** Use `async` / `await` through `SolveAsync` for scalable .NET automation.
- 🌐 **Automation-ready:** Designed for browser automation, scraping, testing, and backend workflows.
- 🛡️ **Proxy support:** Send proxy settings with task types that require browser-session matching.
- 💰 **Cost-effective:** Low-cost pricing structure based on pay-as-you-go balance.
- 📉 **Cheaper than alternatives:** reCAPTCHA v3 from $0.90 per 1,000 solves, versus $1.45 at 2Captcha and $1.00 at Capsolver.
- 🔄 **Easy migration:** replace your 2Captcha or Capsolver solver call and keep the rest of your scraper or bot unchanged.
- 📖 **Official docs:** request types follow the [CapMonster Cloud API documentation](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

---

## 📊 CapMonster Cloud vs 2Captcha vs Capsolver

Looking for a 2captcha alternative or a capsolver alternative for .NET web scraping and automation? Compare price, speed and success rate.

### reCAPTCHA v3

| Parameter | CapMonster Cloud | 2Captcha | CapSolver | DeathByCaptcha |
| :--- | :---: | :---: | :---: | :---: |
| Price per 1,000 solves (from) | **$0.90** | $1.45 | $1.00 | $2.89 |
| API response time | **≤ 2 s** | ≤ 2 s | < 3 s | ≤ 3 s |
| Solving success rate | **up to 99%** | ~77–92% | ~95–98% | ~64–90% |

*Disclaimer: 2Captcha, CapSolver, and DeathByCaptcha are trademarks of their respective owners. CapMonster Cloud is not affiliated with these entities. Performance metrics and pricing comparisons are based on publicly available data and internal benchmarking conducted on 27.09.2026.*

### Cloudflare Turnstile

| Parameter | CapMonster Cloud | 2Captcha | Anti-Captcha | DeathByCaptcha |
| :--- | :---: | :---: | :---: | :---: |
| Price per 1,000 solves (from) | **$1.30** | $1.45 | $2.00 | $2.89 |
| Time to solve | **6.24 s\*** | 16.9 s | 20.33 s | ~13 s |
| Solving success rate | **99%\*** | 96% | 96% | 96% |

*Disclaimer: 2Captcha, Anti-Captcha, and DeathByCaptcha are trademarks of their respective owners. CapMonster Cloud is not affiliated with these entities. Performance metrics and pricing comparisons are based on publicly available data and internal benchmarking as of 12.10.2026.*

**What this means in practice:**

- **reCAPTCHA v3:** $0.90 versus $1.45 at 2Captcha is up to 38% cheaper, and $0.90 versus $1.00 at Capsolver is 10% cheaper.
- **Cloudflare Turnstile:** $1.30 versus $1.45 at 2Captcha is 10% cheaper, and a solving time of 6.24 s versus 16.9 s is more than 60% faster.

---

## 📦 Installation

Install via the NuGet Package Manager:

```powershell
Install-Package Zennolab.CapMonsterCloud.Client
```

Or install through the .NET CLI:

```bash
dotnet add package Zennolab.CapMonsterCloud.Client
```

The package targets .NET Standard 2.0.

---

## 🚀 Quick Start: Solve and Bypass Captchas in .NET

### 1. Initialize the Client

Create an API key in the [CapMonster Cloud Dashboard](https://dash.capmonster.cloud/Account/SignUp?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme), then initialize the client:

```csharp
using Zennolab.CapMonsterCloud.Client;
using Zennolab.CapMonsterCloud.Client.Options;
using Zennolab.CapMonsterCloud.Client.Requests;

var clientOptions = new ClientOptions
{
    ClientKey = "YOUR_CAPMONSTER_CLOUD_API_KEY"
};

var cmCloudClient = CapMonsterCloudClientFactory.Create(clientOptions);
```

### 2. Solve reCAPTCHA v2 with a Proxy

```csharp
var recaptchaV2Request = new RecaptchaV2Request
{
    WebsiteUrl = "https://lessons.zennolab.com/captchas/recaptcha/v2_simple.php?level=high",
    WebsiteKey = "6Lcg7CMUAAAAANphynKgn9YAgA4tQ2KI_iqRyTwd",
    Proxy = new ProxyContainer(
        "203.0.113.45",
        8080,
        ProxyType.Http,
        "login",
        "password")
};

var result = await cmCloudClient.SolveAsync(recaptchaV2Request);
Console.WriteLine($"Solved token: {result.Solution.GRecaptchaResponse}");
```

### 3. Submit a Custom WAF Task

Use custom-task request models for supported advanced protection systems. Consult the [supported CAPTCHA task documentation](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme) for required payload fields and the task type that matches your integration.

```csharp
var tspdRequest = new TspdCustomTaskRequest(
    tspdCookie: "TS386a400d029=...",
    htmlPageBase64: "PCFET0NU...k+PC9odG1sPg==")
{
    WebsiteUrl = "https://yourwebsite.com/page-with-tspd",
    Proxy = new ProxyContainer(
        "203.0.113.45",
        8080,
        ProxyType.Http,
        "login",
        "password")
};

var result = await cmCloudClient.SolveAsync(tspdRequest);
```

---

## 🔄 Migrating from 2Captcha or Capsolver

Already use 2Captcha or Capsolver in your C# scraper or bot? Replace only the solver call and keep the rest of your code unchanged. CapMonster Cloud follows the same flow: send the website URL and sitekey, receive the token.

### Before: 2Captcha (2captcha-csharp)

```csharp
// Before: 2Captcha
TwoCaptcha solver = new TwoCaptcha("YOUR_2CAPTCHA_API_KEY");

ReCaptcha captcha = new ReCaptcha();
captcha.SetSiteKey("YOUR_SITE_KEY");
captcha.SetUrl("https://target-website.com/page-with-recaptcha");

await solver.Solve(captcha);
var token = captcha.Code;
```

### Migrating from Capsolver

CapMonster Cloud uses the same `createTask` / `getTaskResult` flow, so if you call the Capsolver HTTP API directly from .NET, you can switch to the CapMonster Cloud .NET SDK or follow the [API Methods Reference](https://docs.capmonster.cloud/docs/methods/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

### After: CapMonster Cloud

```csharp
// After: CapMonster Cloud
using Zennolab.CapMonsterCloud.Client;
using Zennolab.CapMonsterCloud.Client.Options;
using Zennolab.CapMonsterCloud.Client.Requests;

var cmCloudClient = CapMonsterCloudClientFactory.Create(
    new ClientOptions { ClientKey = "YOUR_CAPMONSTER_CLOUD_API_KEY" });

var request = new RecaptchaV2Request
{
    WebsiteUrl = "https://target-website.com/page-with-recaptcha",
    WebsiteKey = "YOUR_SITE_KEY",
    Proxy = new ProxyContainer(
        "203.0.113.45",
        8080,
        ProxyType.Http,
        "login",
        "password")
};

var result = await cmCloudClient.SolveAsync(request);
var token = result.Solution.GRecaptchaResponse;
```

Only the client, the API key and the request class change: the token is used exactly as before, so the rest of your scraper stays the same.

### Keep existing 2Captcha-based software

Software that already speaks the 2Captcha API can work with CapMonster Cloud without code changes. See the [guide for connecting other services' APIs](https://docs.capmonster.cloud/docs/external-services/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

---

## 🛡️ Supported CAPTCHA Types: Bypass reCAPTCHA, Cloudflare Turnstile, GeeTest and More

Use this C# captcha solver for captcha bypass in web scraping and automation: reCAPTCHA bypass (v2, v2 Enterprise, v3), Cloudflare Turnstile solver, DataDome solver, GeeTest solver, Amazon WAF bypass, Imperva and image-to-text recognition.

All task types follow the official [CapMonster Cloud API documentation](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme):

| Task family | Example request classes in this SDK |
| :--- | :--- |
| **reCAPTCHA** | `RecaptchaV2Request`, `RecaptchaV2EnterpriseRequest`, `RecaptchaV3ProxylessRequest`, `RecaptchaV3EnterpriseRequest` |
| **Cloudflare Turnstile** | `TurnstileRequest` |
| **GeeTest** | `GeeTestRequest` |
| **Amazon WAF** | `AmazonWafRequest` |
| **Image-to-Text** | `ImageToTextRequest` |
| **Complex image tasks** | `RecaptchaComplexImageTaskRequest`, `RecognitionComplexImageTaskRequest` |
| **Custom anti-bot tasks** | `DataDomeCustomTaskRequest`, `ImpervaCustomTaskRequest`, `TspdCustomTaskRequest`, and other supported custom-task classes |

---

## 🛠️ How It Works

```text
[ .NET Application / Browser Automation ]
         │
         ▼
[ Extract sitekey & website URL ]
         │
         ▼
[ CapMonster Cloud .NET SDK ] ──► createTask API request
         │
         ▼
[ Neural Network Processing ] ──► Poll getTaskResult until the task is ready
         │
         ▼
[ Receive Token & Autosubmit ] ──► Complete bypass
```

---

## ⚙️ Best Practices

- **Use tokens promptly:** CAPTCHA tokens expire quickly (a reCAPTCHA v2 token is valid for 60 seconds after solving), so submit or inject the solution immediately after receiving the response.
- **Keep session context consistent:** When a task uses a proxy, use the same proxy in your scraping or browser session and in the CapMonster task.
- **Use the right task type:** Choose the request type that matches the target protection and follow the required parameters in the [documentation](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).
- **Monitor your balance:** Keep your account balance positive in the [Dashboard](https://dash.capmonster.cloud/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme) and handle API errors in your code.

---

## 💡 Use Cases

- **Web scraping and data collection** from websites you are authorized to access, without manual captcha solving.
- **Browser automation:** get the solution token in .NET and inject it into the page with your automation tool.
- **Automated testing (QA)** of your own website and its captcha-protected forms.
- **Backend services** that need a captcha solving API inside a .NET application.

---

## ❓ FAQ

**Is CapMonster Cloud a 2Captcha alternative for .NET?**
Yes. It is a captcha solving service with an official .NET SDK. For reCAPTCHA v3 it starts at $0.90 per 1,000 solves versus $1.45 at 2Captcha, which is up to 38% cheaper. For Cloudflare Turnstile it starts at $1.30 versus $1.45, which is 10% cheaper.

**Is CapMonster Cloud a Capsolver alternative for .NET?**
Yes. For reCAPTCHA v3 it is 10% cheaper than Capsolver ($0.90 versus $1.00 per 1,000 solves) and shows an API response time of ≤ 2 s versus < 3 s. See the comparison table above and its disclaimer.

**How do I migrate from 2Captcha or Capsolver to CapMonster Cloud in .NET?**
Install `Zennolab.CapMonsterCloud.Client`, create a client with `CapMonsterCloudClientFactory.Create`, build the matching request class and call `SolveAsync`. See the migration examples above. Software that already supports the 2Captcha API can also be connected through the [CapMonster Cloud guide](https://docs.capmonster.cloud/docs/external-services/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

**Is there an official .NET captcha solver from CapMonster Cloud?**
Yes. This repository is the official .NET client library for the CapMonster Cloud captcha solving service.

**How do I bypass reCAPTCHA v2 in .NET?**
Create a client with your API key, build a `RecaptchaV2Request` with the page URL, sitekey and proxy, call `SolveAsync` and use `result.Solution.GRecaptchaResponse`. See the [reCAPTCHA v2 documentation](https://docs.capmonster.cloud/docs/captchas/no-captcha-task/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

**How do I bypass Cloudflare Turnstile in .NET?**
Use `TurnstileRequest` with `SolveAsync`. According to the [Turnstile documentation](https://docs.capmonster.cloud/docs/captchas/turnstile-task/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme), all Turnstile subtypes are supported automatically: manual, non-interactive and invisible.

**Which captcha types does the .NET SDK solve?**
reCAPTCHA v2, v3 and Enterprise, Cloudflare Turnstile, GeeTest, Amazon WAF, DataDome, Imperva, image-to-text and complex image tasks, and other custom-task classes. See the supported types table above and the [Supported Captchas Overview](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

**How do I get an API key?**
Register on CapMonster Cloud, top up your balance and copy your API key. The [Getting Started Guide](https://docs.capmonster.cloud/docs/getting-start/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme) describes each step.

**Which .NET versions are supported?**
The package targets .NET Standard 2.0.

**How fast are captchas solved?**
On average between 1 and 30 seconds, depending on the captcha type. More details are in the [CapMonster Cloud FAQ](https://docs.capmonster.cloud/docs/faq/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

**How long is a reCAPTCHA v2 solution valid?**
According to the [reCAPTCHA v2 documentation](https://docs.capmonster.cloud/docs/captchas/no-captcha-task/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme), the returned token is valid for 60 seconds after the captcha is solved, so use it right away.

**Where is the full API reference?**
See the [API Methods Reference](https://docs.capmonster.cloud/docs/methods/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

---

## ⚖️ Responsible Use

CapMonster Cloud is intended for legitimate business purposes only, such as testing your own website or a website you are authorized to test, and recognizing images you provide. Read more about [ethical and transparent captcha automation](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme).

---

## 📚 Documentation & Support

- 📖 [Getting Started Guide](https://docs.capmonster.cloud/docs/getting-start/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 🎯 [Supported Captchas Overview](https://docs.capmonster.cloud/docs/captchas/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- ⚙️ [API Methods Reference](https://docs.capmonster.cloud/docs/methods/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- ❓ [CapMonster Cloud FAQ](https://docs.capmonster.cloud/docs/faq/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 🌐 [Browser Extension Guides](https://docs.capmonster.cloud/docs/extension/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)
- 💬 [Support & Community](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme#support)

## Other official SDKs & integrations

- [Python](https://github.com/CapMonsterCloud/capmonster-python-captcha-solver)
- [Node.js](https://github.com/CapMonsterCloud/capmonster-nodejs-captcha-solver)
- [Go](https://github.com/CapMonsterCloud/capmonster-go-captcha-solver)
- [PHP](https://github.com/CapMonsterCloud/capmonster-php-captcha-solver)
- [Rust](https://github.com/CapMonsterCloud/capmonster-rust-captcha-solver)
- [n8n](https://github.com/CapMonsterCloud/capmonster-n8n-captcha-solver)
- [MCP server](https://github.com/CapMonsterCloud/capmonster-mcp-captcha-solver)
- [MCP server for Patchright](https://github.com/CapMonsterCloud/capmonster-mcp-patchright-captcha-solver)
- [API Docs](https://github.com/CapMonsterCloud/capmonster-captcha-solver-docs)

---

## 📄 License

[MIT](https://github.com/CapMonsterCloud/capmonster-dotnet-captcha-solver/blob/main/LICENSE) © [CapMonster Cloud](https://capmonster.cloud/en/?utm_source=github&utm_medium=referral&utm_campaign=dotnet_repo_readme)

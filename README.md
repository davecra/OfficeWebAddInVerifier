# Office Web Add-In Verifier
 This tool helps to validate an Office Web Add-in by performing the following steps:
 1) Validates the parts of the manifest are accurate.
 2) Validates each URL in the manifest is rechable
 3) Validates the taskpnae/functions/dialog HTML/JS locations
 4) Validates all files in the solution are rechable in the publish location
 5) For Outlook can validate that EWS and the OWA/EWS services are accessible.

**NOTE**: This is a best effrot to validate a manifest. This does not replace the [Office Manifest Validation process](https://docs.microsoft.com/en-us/office/dev/add-ins/testing/troubleshoot-manifest) (npm run validate). This validates the DEPLOYMENT manifest for validitty and accessibility only.

# Issues
At this point there are no known issues with this tool.
If you encounter an issue please submit an issue.

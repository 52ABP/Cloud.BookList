using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cloud.BookList.Migrations
{
    public partial class AddCloudBookListEntitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs");

            migrationBuilder.EnsureSchema(
                name: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserTokens",
                newName: "UserTokens",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUsers",
                newName: "Users",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserRoles",
                newName: "UserRoles",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserOrganizationUnits",
                newName: "UserOrganizationUnits",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserNotifications",
                newName: "UserNotifications",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserLogins",
                newName: "UserLogins",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserLoginAttempts",
                newName: "UserLoginAttempts",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserClaims",
                newName: "UserClaims",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpUserAccounts",
                newName: "UserAccounts",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpTenants",
                newName: "Tenants",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpTenantNotifications",
                newName: "TenantNotifications",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpSettings",
                newName: "Settings",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpRoles",
                newName: "Roles",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpRoleClaims",
                newName: "RoleClaims",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpPermissions",
                newName: "Permissions",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpOrganizationUnits",
                newName: "OrganizationUnits",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpNotificationSubscriptions",
                newName: "NotificationSubscriptions",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpNotifications",
                newName: "Notifications",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpLanguageTexts",
                newName: "LanguageTexts",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpLanguages",
                newName: "Languages",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpFeatures",
                newName: "Features",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpEntityPropertyChanges",
                newName: "EntityPropertyChanges",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpEntityChangeSets",
                newName: "EntityChangeSets",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpEntityChanges",
                newName: "EntityChanges",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpEditions",
                newName: "Editions",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpBackgroundJobs",
                newName: "BackgroundJobs",
                newSchema: "ABP");

            migrationBuilder.RenameTable(
                name: "AbpAuditLogs",
                newName: "AuditLogs",
                newSchema: "ABP");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_TenantId_UserId",
                schema: "ABP",
                table: "UserTokens",
                newName: "IX_UserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserTokens_UserId",
                schema: "ABP",
                table: "UserTokens",
                newName: "IX_UserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedUserName",
                schema: "ABP",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_TenantId_NormalizedEmailAddress",
                schema: "ABP",
                table: "Users",
                newName: "IX_Users_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_LastModifierUserId",
                schema: "ABP",
                table: "Users",
                newName: "IX_Users_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_DeleterUserId",
                schema: "ABP",
                table: "Users",
                newName: "IX_Users_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUsers_CreatorUserId",
                schema: "ABP",
                table: "Users",
                newName: "IX_Users_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_UserId",
                schema: "ABP",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_TenantId_RoleId",
                schema: "ABP",
                table: "UserRoles",
                newName: "IX_UserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserRoles_UserId",
                schema: "ABP",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_UserId",
                schema: "ABP",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId",
                schema: "ABP",
                table: "UserOrganizationUnits",
                newName: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserNotifications_UserId_State_CreationTime",
                schema: "ABP",
                table: "UserNotifications",
                newName: "IX_UserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey",
                schema: "ABP",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_TenantId_UserId",
                schema: "ABP",
                table: "UserLogins",
                newName: "IX_UserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLogins_UserId",
                schema: "ABP",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                schema: "ABP",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserLoginAttempts_UserId_TenantId",
                schema: "ABP",
                table: "UserLoginAttempts",
                newName: "IX_UserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_TenantId_ClaimType",
                schema: "ABP",
                table: "UserClaims",
                newName: "IX_UserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserClaims_UserId",
                schema: "ABP",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserName",
                schema: "ABP",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_UserId",
                schema: "ABP",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_TenantId_EmailAddress",
                schema: "ABP",
                table: "UserAccounts",
                newName: "IX_UserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_UserName",
                schema: "ABP",
                table: "UserAccounts",
                newName: "IX_UserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpUserAccounts_EmailAddress",
                schema: "ABP",
                table: "UserAccounts",
                newName: "IX_UserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_TenancyName",
                schema: "ABP",
                table: "Tenants",
                newName: "IX_Tenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_LastModifierUserId",
                schema: "ABP",
                table: "Tenants",
                newName: "IX_Tenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_EditionId",
                schema: "ABP",
                table: "Tenants",
                newName: "IX_Tenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_DeleterUserId",
                schema: "ABP",
                table: "Tenants",
                newName: "IX_Tenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenants_CreatorUserId",
                schema: "ABP",
                table: "Tenants",
                newName: "IX_Tenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpTenantNotifications_TenantId",
                schema: "ABP",
                table: "TenantNotifications",
                newName: "IX_TenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_TenantId_Name",
                schema: "ABP",
                table: "Settings",
                newName: "IX_Settings_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpSettings_UserId",
                schema: "ABP",
                table: "Settings",
                newName: "IX_Settings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_TenantId_NormalizedName",
                schema: "ABP",
                table: "Roles",
                newName: "IX_Roles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_LastModifierUserId",
                schema: "ABP",
                table: "Roles",
                newName: "IX_Roles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_DeleterUserId",
                schema: "ABP",
                table: "Roles",
                newName: "IX_Roles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoles_CreatorUserId",
                schema: "ABP",
                table: "Roles",
                newName: "IX_Roles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_TenantId_ClaimType",
                schema: "ABP",
                table: "RoleClaims",
                newName: "IX_RoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_AbpRoleClaims_RoleId",
                schema: "ABP",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_UserId",
                schema: "ABP",
                table: "Permissions",
                newName: "IX_Permissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_RoleId",
                schema: "ABP",
                table: "Permissions",
                newName: "IX_Permissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpPermissions_TenantId_Name",
                schema: "ABP",
                table: "Permissions",
                newName: "IX_Permissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_TenantId_Code",
                schema: "ABP",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                schema: "ABP",
                table: "OrganizationUnits",
                newName: "IX_OrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "ABP",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                schema: "ABP",
                table: "NotificationSubscriptions",
                newName: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key",
                schema: "ABP",
                table: "LanguageTexts",
                newName: "IX_LanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_AbpLanguages_TenantId_Name",
                schema: "ABP",
                table: "Languages",
                newName: "IX_Languages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_TenantId_Name",
                schema: "ABP",
                table: "Features",
                newName: "IX_Features_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpFeatures_EditionId_Name",
                schema: "ABP",
                table: "Features",
                newName: "IX_Features_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                schema: "ABP",
                table: "EntityPropertyChanges",
                newName: "IX_EntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_UserId",
                schema: "ABP",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_Reason",
                schema: "ABP",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChangeSets_TenantId_CreationTime",
                schema: "ABP",
                table: "EntityChangeSets",
                newName: "IX_EntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityTypeFullName_EntityId",
                schema: "ABP",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpEntityChanges_EntityChangeSetId",
                schema: "ABP",
                table: "EntityChanges",
                newName: "IX_EntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                schema: "ABP",
                table: "BackgroundJobs",
                newName: "IX_BackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId",
                schema: "ABP",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                schema: "ABP",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionDuration",
                schema: "ABP",
                table: "AuditLogs",
                newName: "IX_AuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                schema: "ABP",
                table: "UserTokens",
                maxLength: 128,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireDate",
                schema: "ABP",
                table: "UserTokens",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "ABP",
                table: "Users",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                schema: "ABP",
                table: "Users",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                schema: "ABP",
                table: "Users",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "ABP",
                table: "Users",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "ABP",
                table: "UserAccounts",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                schema: "ABP",
                table: "UserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "ABP",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                schema: "ABP",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "ABP",
                table: "UserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNotifications",
                schema: "ABP",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                schema: "ABP",
                table: "UserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "ABP",
                table: "UserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                schema: "ABP",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                schema: "ABP",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenants",
                schema: "ABP",
                table: "Tenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "ABP",
                table: "TenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settings",
                schema: "ABP",
                table: "Settings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "ABP",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                schema: "ABP",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                schema: "ABP",
                table: "Permissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "ABP",
                table: "OrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "ABP",
                table: "NotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                schema: "ABP",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "ABP",
                table: "LanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                schema: "ABP",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Features",
                schema: "ABP",
                table: "Features",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "ABP",
                table: "EntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "ABP",
                table: "EntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityChanges",
                schema: "ABP",
                table: "EntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Editions",
                schema: "ABP",
                table: "Editions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "ABP",
                table: "BackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditLogs",
                schema: "ABP",
                table: "AuditLogs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BookLists",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Intro = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImgUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Intro = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookTags",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookListAndBookRelationship",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookListId = table.Column<long>(nullable: false),
                    BookId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookListAndBookRelationship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookListAndBookRelationship_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookListAndBookRelationship_BookLists_BookListId",
                        column: x => x.BookListId,
                        principalTable: "BookLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAndBookTagRelationships",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<long>(nullable: false),
                    BookTagId = table.Column<long>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAndBookTagRelationships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAndBookTagRelationships_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookAndBookTagRelationships_BookTags_BookTagId",
                        column: x => x.BookTagId,
                        principalTable: "BookTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAndBookTagRelationships_BookId",
                table: "BookAndBookTagRelationships",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAndBookTagRelationships_BookTagId",
                table: "BookAndBookTagRelationships",
                column: "BookTagId");

            migrationBuilder.CreateIndex(
                name: "IX_BookListAndBookRelationship_BookId",
                table: "BookListAndBookRelationship",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookListAndBookRelationship_BookListId",
                table: "BookListAndBookRelationship",
                column: "BookListId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "ABP",
                table: "EntityChanges",
                column: "EntityChangeSetId",
                principalSchema: "ABP",
                principalTable: "EntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "ABP",
                table: "EntityPropertyChanges",
                column: "EntityChangeId",
                principalSchema: "ABP",
                principalTable: "EntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "ABP",
                table: "Features",
                column: "EditionId",
                principalSchema: "ABP",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "ABP",
                table: "OrganizationUnits",
                column: "ParentId",
                principalSchema: "ABP",
                principalTable: "OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "ABP",
                table: "Permissions",
                column: "RoleId",
                principalSchema: "ABP",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "ABP",
                table: "Permissions",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "ABP",
                table: "RoleClaims",
                column: "RoleId",
                principalSchema: "ABP",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "ABP",
                table: "Roles",
                column: "CreatorUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "ABP",
                table: "Roles",
                column: "DeleterUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "ABP",
                table: "Roles",
                column: "LastModifierUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "ABP",
                table: "Settings",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "ABP",
                table: "Tenants",
                column: "CreatorUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "ABP",
                table: "Tenants",
                column: "DeleterUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "ABP",
                table: "Tenants",
                column: "EditionId",
                principalSchema: "ABP",
                principalTable: "Editions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "ABP",
                table: "Tenants",
                column: "LastModifierUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "ABP",
                table: "UserClaims",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "ABP",
                table: "UserLogins",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "ABP",
                table: "UserRoles",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "ABP",
                table: "Users",
                column: "CreatorUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "ABP",
                table: "Users",
                column: "DeleterUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "ABP",
                table: "Users",
                column: "LastModifierUserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "ABP",
                table: "UserTokens",
                column: "UserId",
                principalSchema: "ABP",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityChanges_EntityChangeSets_EntityChangeSetId",
                schema: "ABP",
                table: "EntityChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityPropertyChanges_EntityChanges_EntityChangeId",
                schema: "ABP",
                table: "EntityPropertyChanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Editions_EditionId",
                schema: "ABP",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationUnits_OrganizationUnits_ParentId",
                schema: "ABP",
                table: "OrganizationUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Roles_RoleId",
                schema: "ABP",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Users_UserId",
                schema: "ABP",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                schema: "ABP",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_CreatorUserId",
                schema: "ABP",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_DeleterUserId",
                schema: "ABP",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_LastModifierUserId",
                schema: "ABP",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Settings_Users_UserId",
                schema: "ABP",
                table: "Settings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_CreatorUserId",
                schema: "ABP",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_DeleterUserId",
                schema: "ABP",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Editions_EditionId",
                schema: "ABP",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Users_LastModifierUserId",
                schema: "ABP",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                schema: "ABP",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                schema: "ABP",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                schema: "ABP",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatorUserId",
                schema: "ABP",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeleterUserId",
                schema: "ABP",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_LastModifierUserId",
                schema: "ABP",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                schema: "ABP",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "BookAndBookTagRelationships");

            migrationBuilder.DropTable(
                name: "BookListAndBookRelationship");

            migrationBuilder.DropTable(
                name: "BookTags");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                schema: "ABP",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "ABP",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                schema: "ABP",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserOrganizationUnits",
                schema: "ABP",
                table: "UserOrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNotifications",
                schema: "ABP",
                table: "UserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                schema: "ABP",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLoginAttempts",
                schema: "ABP",
                table: "UserLoginAttempts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                schema: "ABP",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                schema: "ABP",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenants",
                schema: "ABP",
                table: "Tenants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TenantNotifications",
                schema: "ABP",
                table: "TenantNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settings",
                schema: "ABP",
                table: "Settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "ABP",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                schema: "ABP",
                table: "RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                schema: "ABP",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganizationUnits",
                schema: "ABP",
                table: "OrganizationUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationSubscriptions",
                schema: "ABP",
                table: "NotificationSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                schema: "ABP",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LanguageTexts",
                schema: "ABP",
                table: "LanguageTexts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                schema: "ABP",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Features",
                schema: "ABP",
                table: "Features");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityPropertyChanges",
                schema: "ABP",
                table: "EntityPropertyChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChangeSets",
                schema: "ABP",
                table: "EntityChangeSets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityChanges",
                schema: "ABP",
                table: "EntityChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Editions",
                schema: "ABP",
                table: "Editions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundJobs",
                schema: "ABP",
                table: "BackgroundJobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditLogs",
                schema: "ABP",
                table: "AuditLogs");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                schema: "ABP",
                table: "UserTokens");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "ABP",
                newName: "AbpUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "ABP",
                newName: "AbpUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "ABP",
                newName: "AbpUserRoles");

            migrationBuilder.RenameTable(
                name: "UserOrganizationUnits",
                schema: "ABP",
                newName: "AbpUserOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "UserNotifications",
                schema: "ABP",
                newName: "AbpUserNotifications");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "ABP",
                newName: "AbpUserLogins");

            migrationBuilder.RenameTable(
                name: "UserLoginAttempts",
                schema: "ABP",
                newName: "AbpUserLoginAttempts");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "ABP",
                newName: "AbpUserClaims");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                schema: "ABP",
                newName: "AbpUserAccounts");

            migrationBuilder.RenameTable(
                name: "Tenants",
                schema: "ABP",
                newName: "AbpTenants");

            migrationBuilder.RenameTable(
                name: "TenantNotifications",
                schema: "ABP",
                newName: "AbpTenantNotifications");

            migrationBuilder.RenameTable(
                name: "Settings",
                schema: "ABP",
                newName: "AbpSettings");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "ABP",
                newName: "AbpRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "ABP",
                newName: "AbpRoleClaims");

            migrationBuilder.RenameTable(
                name: "Permissions",
                schema: "ABP",
                newName: "AbpPermissions");

            migrationBuilder.RenameTable(
                name: "OrganizationUnits",
                schema: "ABP",
                newName: "AbpOrganizationUnits");

            migrationBuilder.RenameTable(
                name: "NotificationSubscriptions",
                schema: "ABP",
                newName: "AbpNotificationSubscriptions");

            migrationBuilder.RenameTable(
                name: "Notifications",
                schema: "ABP",
                newName: "AbpNotifications");

            migrationBuilder.RenameTable(
                name: "LanguageTexts",
                schema: "ABP",
                newName: "AbpLanguageTexts");

            migrationBuilder.RenameTable(
                name: "Languages",
                schema: "ABP",
                newName: "AbpLanguages");

            migrationBuilder.RenameTable(
                name: "Features",
                schema: "ABP",
                newName: "AbpFeatures");

            migrationBuilder.RenameTable(
                name: "EntityPropertyChanges",
                schema: "ABP",
                newName: "AbpEntityPropertyChanges");

            migrationBuilder.RenameTable(
                name: "EntityChangeSets",
                schema: "ABP",
                newName: "AbpEntityChangeSets");

            migrationBuilder.RenameTable(
                name: "EntityChanges",
                schema: "ABP",
                newName: "AbpEntityChanges");

            migrationBuilder.RenameTable(
                name: "Editions",
                schema: "ABP",
                newName: "AbpEditions");

            migrationBuilder.RenameTable(
                name: "BackgroundJobs",
                schema: "ABP",
                newName: "AbpBackgroundJobs");

            migrationBuilder.RenameTable(
                name: "AuditLogs",
                schema: "ABP",
                newName: "AbpAuditLogs");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_TenantId_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTokens_UserId",
                table: "AbpUserTokens",
                newName: "IX_AbpUserTokens_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedUserName",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedUserName");

            migrationBuilder.RenameIndex(
                name: "IX_Users_TenantId_NormalizedEmailAddress",
                table: "AbpUsers",
                newName: "IX_AbpUsers_TenantId_NormalizedEmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LastModifierUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeleterUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatorUserId",
                table: "AbpUsers",
                newName: "IX_AbpUsers_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_TenantId_RoleId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_TenantId_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "AbpUserRoles",
                newName: "IX_AbpUserRoles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_UserId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserOrganizationUnits_TenantId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                newName: "IX_AbpUserOrganizationUnits_TenantId_OrganizationUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_UserId_State_CreationTime",
                table: "AbpUserNotifications",
                newName: "IX_AbpUserNotifications_UserId_State_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_LoginProvider_ProviderKey");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_TenantId_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AbpUserLogins",
                newName: "IX_AbpUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_TenancyName_UserNameOrEmailAddress_Result");

            migrationBuilder.RenameIndex(
                name: "IX_UserLoginAttempts_UserId_TenantId",
                table: "AbpUserLoginAttempts",
                newName: "IX_AbpUserLoginAttempts_UserId_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_TenantId_ClaimType",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AbpUserClaims",
                newName: "IX_AbpUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_UserId",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_TenantId_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_TenantId_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_UserName",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_UserName");

            migrationBuilder.RenameIndex(
                name: "IX_UserAccounts_EmailAddress",
                table: "AbpUserAccounts",
                newName: "IX_AbpUserAccounts_EmailAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_TenancyName",
                table: "AbpTenants",
                newName: "IX_AbpTenants_TenancyName");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_LastModifierUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_EditionId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_EditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_DeleterUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenants_CreatorUserId",
                table: "AbpTenants",
                newName: "IX_AbpTenants_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_TenantNotifications_TenantId",
                table: "AbpTenantNotifications",
                newName: "IX_AbpTenantNotifications_TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_TenantId_Name",
                table: "AbpSettings",
                newName: "IX_AbpSettings_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Settings_UserId",
                table: "AbpSettings",
                newName: "IX_AbpSettings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_TenantId_NormalizedName",
                table: "AbpRoles",
                newName: "IX_AbpRoles_TenantId_NormalizedName");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_LastModifierUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_LastModifierUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_DeleterUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_DeleterUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_CreatorUserId",
                table: "AbpRoles",
                newName: "IX_AbpRoles_CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_TenantId_ClaimType",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_TenantId_ClaimType");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AbpRoleClaims",
                newName: "IX_AbpRoleClaims_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_UserId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_RoleId",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_TenantId_Name",
                table: "AbpPermissions",
                newName: "IX_AbpPermissions_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_TenantId_Code",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_TenantId_Code");

            migrationBuilder.RenameIndex(
                name: "IX_OrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                newName: "IX_AbpOrganizationUnits_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_TenantId_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId",
                table: "AbpNotificationSubscriptions",
                newName: "IX_AbpNotificationSubscriptions_NotificationName_EntityTypeName_EntityId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LanguageTexts_TenantId_Source_LanguageName_Key",
                table: "AbpLanguageTexts",
                newName: "IX_AbpLanguageTexts_TenantId_Source_LanguageName_Key");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_TenantId_Name",
                table: "AbpLanguages",
                newName: "IX_AbpLanguages_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_TenantId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_TenantId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Features_EditionId_Name",
                table: "AbpFeatures",
                newName: "IX_AbpFeatures_EditionId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_EntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                newName: "IX_AbpEntityPropertyChanges_EntityChangeId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_UserId",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_Reason",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_Reason");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChangeSets_TenantId_CreationTime",
                table: "AbpEntityChangeSets",
                newName: "IX_AbpEntityChangeSets_TenantId_CreationTime");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityTypeFullName_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityChanges_EntityChangeSetId",
                table: "AbpEntityChanges",
                newName: "IX_AbpEntityChanges_EntityChangeSetId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                newName: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_UserId",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionTime");

            migrationBuilder.RenameIndex(
                name: "IX_AuditLogs_TenantId_ExecutionDuration",
                table: "AbpAuditLogs",
                newName: "IX_AbpAuditLogs_TenantId_ExecutionDuration");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AbpUserTokens",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 128,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AbpUsers",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "AbpUsers",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AbpUsers",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AbpUsers",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AbpUserAccounts",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserTokens",
                table: "AbpUserTokens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUsers",
                table: "AbpUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserRoles",
                table: "AbpUserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserOrganizationUnits",
                table: "AbpUserOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserNotifications",
                table: "AbpUserNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLogins",
                table: "AbpUserLogins",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserLoginAttempts",
                table: "AbpUserLoginAttempts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserClaims",
                table: "AbpUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpUserAccounts",
                table: "AbpUserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenants",
                table: "AbpTenants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpTenantNotifications",
                table: "AbpTenantNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpSettings",
                table: "AbpSettings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoles",
                table: "AbpRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpRoleClaims",
                table: "AbpRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpPermissions",
                table: "AbpPermissions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpOrganizationUnits",
                table: "AbpOrganizationUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotificationSubscriptions",
                table: "AbpNotificationSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpNotifications",
                table: "AbpNotifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguageTexts",
                table: "AbpLanguageTexts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpLanguages",
                table: "AbpLanguages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpFeatures",
                table: "AbpFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityPropertyChanges",
                table: "AbpEntityPropertyChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChangeSets",
                table: "AbpEntityChangeSets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEntityChanges",
                table: "AbpEntityChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpEditions",
                table: "AbpEditions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpBackgroundJobs",
                table: "AbpBackgroundJobs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AbpAuditLogs",
                table: "AbpAuditLogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityChanges_AbpEntityChangeSets_EntityChangeSetId",
                table: "AbpEntityChanges",
                column: "EntityChangeSetId",
                principalTable: "AbpEntityChangeSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId",
                principalTable: "AbpEntityChanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpFeatures_AbpEditions_EditionId",
                table: "AbpFeatures",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId",
                principalTable: "AbpOrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpRoles_RoleId",
                table: "AbpPermissions",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpPermissions_AbpUsers_UserId",
                table: "AbpPermissions",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId",
                principalTable: "AbpRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_CreatorUserId",
                table: "AbpRoles",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_DeleterUserId",
                table: "AbpRoles",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpRoles_AbpUsers_LastModifierUserId",
                table: "AbpRoles",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpSettings_AbpUsers_UserId",
                table: "AbpSettings",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_CreatorUserId",
                table: "AbpTenants",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_DeleterUserId",
                table: "AbpTenants",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpEditions_EditionId",
                table: "AbpTenants",
                column: "EditionId",
                principalTable: "AbpEditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_AbpUsers_LastModifierUserId",
                table: "AbpTenants",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserClaims_AbpUsers_UserId",
                table: "AbpUserClaims",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserLogins_AbpUsers_UserId",
                table: "AbpUserLogins",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserRoles_AbpUsers_UserId",
                table: "AbpUserRoles",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_CreatorUserId",
                table: "AbpUsers",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_DeleterUserId",
                table: "AbpUsers",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUsers_AbpUsers_LastModifierUserId",
                table: "AbpUsers",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpUserTokens_AbpUsers_UserId",
                table: "AbpUserTokens",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

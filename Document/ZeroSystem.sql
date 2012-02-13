/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     2012/2/11 15:04:30                           */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('t_Authorization')
            and   type = 'U')
   drop table t_Authorization
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_CallList')
            and   type = 'U')
   drop table t_CallList
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_ChannelStateDynamic')
            and   type = 'U')
   drop table t_ChannelStateDynamic
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_ChannelStateStatic')
            and   type = 'U')
   drop table t_ChannelStateStatic
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_Client')
            and   type = 'U')
   drop table t_Client
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_GlobalPara')
            and   type = 'U')
   drop table t_GlobalPara
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_IVRControl')
            and   type = 'U')
   drop table t_IVRControl
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_Log')
            and   type = 'U')
   drop table t_Log
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_Operation')
            and   type = 'U')
   drop table t_Operation
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_OperationState')
            and   type = 'U')
   drop table t_OperationState
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_Product')
            and   type = 'U')
   drop table t_Product
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_ReceiveList')
            and   type = 'U')
   drop table t_ReceiveList
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_SysUserState')
            and   type = 'U')
   drop table t_SysUserState
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_SystemUser')
            and   type = 'U')
   drop table t_SystemUser
go

if exists (select 1
            from  sysobjects
           where  id = object_id('t_r_OperationProduct')
            and   type = 'U')
   drop table t_r_OperationProduct
go

/*==============================================================*/
/* Table: t_Authorization                                       */
/*==============================================================*/
create table t_Authorization (
   UserID               nvarchar(128)        not null,
   iUserLevel           int                  not null,
   constraint PK_T_AUTHORIZATION primary key (UserID, iUserLevel)
)
go

/*==============================================================*/
/* Table: t_CallList                                            */
/*==============================================================*/
create table t_CallList (
   KeyID                nvarchar(128)        not null,
   sCallNum             nvarchar(50)         null,
   iTimeElapse          int                  null,
   iCallUserCH          int                  null,
   UserID               nvarchar(128)        null,
   ClientID             nvarchar(128)        null,
   Memo                 nvarchar(500)        null,
   constraint PK_T_CALLLIST primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_ChannelStateDynamic                                 */
/*==============================================================*/
create table t_ChannelStateDynamic (
   iChID                int                  not null,
   sChState             nvarchar(50)         null,
   iChType              int                  null,
   sCaller              nvarchar(50)         null,
   sDTMF                nvarchar(50)         null,
   iTimeElapse          int                  null,
   constraint PK_T_CHANNELSTATEDYNAMIC primary key (iChID)
)
go

/*==============================================================*/
/* Table: t_ChannelStateStatic                                  */
/*==============================================================*/
create table t_ChannelStateStatic (
   iChID                int                  not null,
   iChtype              int                  null,
   iChNum               int                  null,
   constraint PK_T_CHANNELSTATESTATIC primary key (iChID)
)
go

/*==============================================================*/
/* Table: t_Client                                              */
/*==============================================================*/
create table t_Client (
   KeyID                nvarchar(128)        not null,
   sClientName          nvarchar(100)        null,
   sAddress             nvarchar(200)        null,
   sMobiPhone           nvarchar(50)         null,
   sTelPhone            nvarchar(50)         null,
   CreateUserID         nvarchar(128)        null,
   Memo                 nvarchar(500)        null,
   IsEnable             bit                  null,
   LastUpdate           datetime             null,
   constraint PK_T_CLIENT primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_GlobalPara                                          */
/*==============================================================*/
create table t_GlobalPara (
   KeyID                int                  not null,
   sValue               nvarchar(50)         null,
   Memo                 nvarchar(200)        null,
   constraint PK_T_GLOBALPARA primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_IVRControl                                          */
/*==============================================================*/
create table t_IVRControl (
   KeyID                nvarchar(128)        not null,
   sFileName            nvarchar(300)        null,
   iKeyNum              int                  null,
   SubID                nvarchar(128)        null,
   sIVRName             nvarchar(50)         null,
   IsEnable             bit                  null,
   BeginDate            datetime             null,
   EndDate              datetime             null,
   LastUpdate           datetime             null,
   constraint PK_T_IVRCONTROL primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_Log                                                 */
/*==============================================================*/
create table t_Log (
   ID                   nvarchar(128)        not null,
   sContent             nvarchar(200)        null,
   sType                nvarchar(50)         null,
   LogTime              datetime             null,
   constraint PK_T_LOG primary key (ID)
)
go

/*==============================================================*/
/* Table: t_Operation                                           */
/*==============================================================*/
create table t_Operation (
   KeyID                nvarchar(128)        not null,
   ClientID             nvarchar(128)        null,
   iStatus              int                  null,
   iTotalPrice          decimal(16,2)        null,
   CreateUser           nvarchar(128)        null,
   Memo                 nvarchar(500)        null,
   IsEnable             bit                  null,
   LastUpdate           datetime             null,
   constraint PK_T_OPERATION primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_OperationState                                      */
/*==============================================================*/
create table t_OperationState (
   KeyID                int                  null,
   sStatusName          nvarchar(50)         null,
   iIndex               int                  null
)
go

/*==============================================================*/
/* Table: t_Product                                             */
/*==============================================================*/
create table t_Product (
   KeyID                uniqueidentifier     not null,
   sProductName         nvarchar(200)        null,
   iPrice               decimal(16,2)        null,
   Memo                 nvarchar(500)        null,
   iDiscount            int                  null,
   IsEnable             bit                  null,
   Begindate            datetime             null,
   Enddate              datetime             null,
   LastUpdate           datetime             null,
   constraint PK_T_PRODUCT primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_ReceiveList                                         */
/*==============================================================*/
create table t_ReceiveList (
   KeyID                nvarchar(128)        not null,
   sCallerID            nvarchar(50)         null,
   ClientID             nvarchar(128)        null,
   SysUserID            nvarchar(128)        null,
   iTimeElapse          int                  null,
   ReceiveDate          datetime             null,
   Memo                 nvarchar(500)        null,
   constraint PK_T_RECEIVELIST primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_SysUserState                                        */
/*==============================================================*/
create table t_SysUserState (
   KeyID                nvarchar(128)        not null,
   UserID               nvarchar(128)        null,
   iState               int                  null,
   LastDate             datetime             null,
   constraint PK_T_SYSUSERSTATE primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_SystemUser                                          */
/*==============================================================*/
create table t_SystemUser (
   KeyID                nvarchar(128)        not null,
   sUserName            nvarchar(50)         null,
   sLoginName           nvarchar(50)         null,
   sPassword            nvarchar(128)        null,
   LastUpdate           datetime             null,
   IsEnable             bit                  null,
   constraint PK_T_SYSTEMUSER primary key (KeyID)
)
go

/*==============================================================*/
/* Table: t_r_OperationProduct                                  */
/*==============================================================*/
create table t_r_OperationProduct (
   KeyID                nvarchar(128)        not null,
   OperationID          nvarchar(128)        null,
   ProductID            nvarchar(128)        null,
   iPrice               decimal(16,2)        null,
   iDiscount            int                  null,
   iCurrentPrice        decimal(16,2)        null,
   constraint PK_T_R_OPERATIONPRODUCT primary key (KeyID)
)
go


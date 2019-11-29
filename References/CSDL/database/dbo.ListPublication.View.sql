USE [QLVT]
GO
/****** Object:  View [dbo].[ListPublication]    Script Date: 12/23/2018 5:05:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ListPublication]
AS
SELECT pub.description, sub.subscriber_server 
FROM dbo.sysmergepublications AS pub, dbo.sysmergesubscriptions AS sub
WHERE pub.pubid = sub.pubid AND pub.pubid <> sub.subid
GO

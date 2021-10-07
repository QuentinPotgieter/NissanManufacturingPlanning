CREATE TABLE [dbo].[SalesRequest] (
    [SalesRequestID] INT  IDENTITY (1, 1) NOT NULL,
    [DateRequired]   DATE NOT NULL,
    [DerivativeID]   INT  NOT NULL,
    [Quantity]       INT  NOT NULL,
    [PlanID]         INT  NULL,
    PRIMARY KEY CLUSTERED ([SalesRequestID] ASC)
);


-- 1.01
-- Add ViewCount column to Post table

ALTER TABLE dbo.Post 
ADD ViewCount int NOT NULL 
CONSTRAINT df_Post_ViewCount DEFAULT 0
GO
ALTER TABLE [dbo].[Admin]
ADD FOREIGN KEY(Position) REFERENCES UserPosition(PositionID);

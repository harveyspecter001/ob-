using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector
{
	// Token: 0x020000C9 RID: 201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TaxCollectorMovement : IMessage<TaxCollectorMovement>, IMessage, IEquatable<TaxCollectorMovement>, IDeepCloneable<TaxCollectorMovement>, IBufferMessage
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00191B20 File Offset: 0x0018FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TaxCollectorMovement> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00191B30 File Offset: 0x0018FD30
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00191B40 File Offset: 0x0018FD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00191B50 File Offset: 0x0018FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovement()
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00191B60 File Offset: 0x0018FD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovement(TaxCollectorMovement other)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00191B70 File Offset: 0x0018FD70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TaxCollectorMovement Clone()
		{
			return null;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00191B80 File Offset: 0x0018FD80
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00191B94 File Offset: 0x0018FD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TaxCollectorMovement.Types.TaxCollectorMovementType MovementType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (TaxCollectorMovement.Types.TaxCollectorMovementType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00191BA4 File Offset: 0x0018FDA4
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00191BB4 File Offset: 0x0018FDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FirstNameId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00191BC4 File Offset: 0x0018FDC4
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00191BD4 File Offset: 0x0018FDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastNameId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00191BE4 File Offset: 0x0018FDE4
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00191BF4 File Offset: 0x0018FDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapExtendedCoordinates Coordinates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00191C04 File Offset: 0x0018FE04
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00191C14 File Offset: 0x0018FE14
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00191C24 File Offset: 0x0018FE24
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00191C34 File Offset: 0x0018FE34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string PlayerName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00191C44 File Offset: 0x0018FE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00191C54 File Offset: 0x0018FE54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TaxCollectorMovement other)
		{
			return true;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00191C64 File Offset: 0x0018FE64
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00191C74 File Offset: 0x0018FE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00191C84 File Offset: 0x0018FE84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00191C94 File Offset: 0x0018FE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00191CA4 File Offset: 0x0018FEA4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00191CB4 File Offset: 0x0018FEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TaxCollectorMovement other)
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00191CC4 File Offset: 0x0018FEC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00191CD4 File Offset: 0x0018FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00191CE4 File Offset: 0x0018FEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TaxCollectorMovement()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 2;
					break;
				case 1:
					return;
				case 2:
					TaxCollectorMovement._parser = new MessageParser<TaxCollectorMovement>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_9bf8e3bf2cc345d6a23caabc34a1f0d0 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_affdd3418c6040e883e142bf711593a7 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f57ce5f5a75c4f899b90ad8e56b209a8 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00191DC8 File Offset: 0x0018FFC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HBTZtPOkleH1926ybrI7()
		{
			return true;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00191DD0 File Offset: 0x0018FFD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TaxCollectorMovement SXMy9bOkchxSnOYnDMXq()
		{
			return null;
		}

		// Token: 0x04000354 RID: 852
		private static readonly MessageParser<TaxCollectorMovement> _parser;

		// Token: 0x04000355 RID: 853
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000356 RID: 854
		public const int MovementTypeFieldNumber = 1;

		// Token: 0x04000357 RID: 855
		private TaxCollectorMovement.Types.TaxCollectorMovementType movementType_;

		// Token: 0x04000358 RID: 856
		public const int FirstNameIdFieldNumber = 2;

		// Token: 0x04000359 RID: 857
		private int firstNameId_;

		// Token: 0x0400035A RID: 858
		public const int LastNameIdFieldNumber = 3;

		// Token: 0x0400035B RID: 859
		private int lastNameId_;

		// Token: 0x0400035C RID: 860
		public const int CoordinatesFieldNumber = 4;

		// Token: 0x0400035D RID: 861
		private MapExtendedCoordinates coordinates_;

		// Token: 0x0400035E RID: 862
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x0400035F RID: 863
		private long playerId_;

		// Token: 0x04000360 RID: 864
		public const int PlayerNameFieldNumber = 6;

		// Token: 0x04000361 RID: 865
		private string playerName_;

		// Token: 0x04000362 RID: 866
		internal static TaxCollectorMovement j5GvieOkk28s6btxBs4U;

		// Token: 0x020000CA RID: 202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x0600092C RID: 2348 RVA: 0x002A9468 File Offset: 0x002A7668
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020000CB RID: 203
			public enum TaxCollectorMovementType
			{
				// Token: 0x04000364 RID: 868
				[OriginalName("TAX_COLLECTOR_UNKNOWN_ACTION")]
				TaxCollectorUnknownAction,
				// Token: 0x04000365 RID: 869
				[OriginalName("TAX_COLLECTOR_HIRED")]
				TaxCollectorHired,
				// Token: 0x04000366 RID: 870
				[OriginalName("TAX_COLLECTOR_HARVESTED")]
				TaxCollectorHarvested,
				// Token: 0x04000367 RID: 871
				[OriginalName("TAX_COLLECTOR_DEFEATED")]
				TaxCollectorDefeated,
				// Token: 0x04000368 RID: 872
				[OriginalName("TAX_COLLECTOR_DESTROYED")]
				TaxCollectorDestroyed
			}
		}
	}
}

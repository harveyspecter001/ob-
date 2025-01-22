using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation
{
	// Token: 0x0200007F RID: 127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TeleportRequest : IMessage<TeleportRequest>, IMessage, IEquatable<TeleportRequest>, IDeepCloneable<TeleportRequest>, IBufferMessage
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0018B194 File Offset: 0x00189394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TeleportRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0018B1A4 File Offset: 0x001893A4
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0018B1B4 File Offset: 0x001893B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0018B1C4 File Offset: 0x001893C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportRequest()
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0018B1D4 File Offset: 0x001893D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportRequest(TeleportRequest other)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0018B1E4 File Offset: 0x001893E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TeleportRequest Clone()
		{
			return null;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0018B1F4 File Offset: 0x001893F4
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x0018B208 File Offset: 0x00189408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Teleporter SourceType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Teleporter)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0018B218 File Offset: 0x00189418
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0018B22C File Offset: 0x0018942C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public Teleporter DestinationType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Teleporter)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0018B23C File Offset: 0x0018943C
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0018B24C File Offset: 0x0018944C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MapId
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

		// Token: 0x06000517 RID: 1303 RVA: 0x0018B25C File Offset: 0x0018945C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0018B26C File Offset: 0x0018946C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(TeleportRequest other)
		{
			return true;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0018B27C File Offset: 0x0018947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0018B28C File Offset: 0x0018948C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0018B29C File Offset: 0x0018949C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0018B2AC File Offset: 0x001894AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0018B2BC File Offset: 0x001894BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0018B2CC File Offset: 0x001894CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(TeleportRequest other)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0018B2DC File Offset: 0x001894DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0018B2EC File Offset: 0x001894EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0018B2FC File Offset: 0x001894FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static TeleportRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_111abe0a4c6f4afe98ab29721d5b86b4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					TeleportRequest._parser = new MessageParser<TeleportRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 4;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0018B3C8 File Offset: 0x001895C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UTnq9AOKCZPuGOXEQHAR()
		{
			return true;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0018B3D0 File Offset: 0x001895D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static TeleportRequest fAcjKAOKDhNugSeFoMh9()
		{
			return null;
		}

		// Token: 0x040001F7 RID: 503
		private static readonly MessageParser<TeleportRequest> _parser;

		// Token: 0x040001F8 RID: 504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001F9 RID: 505
		public const int SourceTypeFieldNumber = 1;

		// Token: 0x040001FA RID: 506
		private Teleporter sourceType_;

		// Token: 0x040001FB RID: 507
		public const int DestinationTypeFieldNumber = 2;

		// Token: 0x040001FC RID: 508
		private Teleporter destinationType_;

		// Token: 0x040001FD RID: 509
		public const int MapIdFieldNumber = 3;

		// Token: 0x040001FE RID: 510
		private long mapId_;

		// Token: 0x040001FF RID: 511
		internal static TeleportRequest g48pGUOK0xH8UCdCpGhT;
	}
}

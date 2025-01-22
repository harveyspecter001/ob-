using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information
{
	// Token: 0x02000D61 RID: 3425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AllianceFactsRequest : IMessage<AllianceFactsRequest>, IMessage, IEquatable<AllianceFactsRequest>, IDeepCloneable<AllianceFactsRequest>, IBufferMessage
	{
		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600A50B RID: 42251 RVA: 0x0029007C File Offset: 0x0028E27C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<AllianceFactsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600A50C RID: 42252 RVA: 0x0029008C File Offset: 0x0028E28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x0600A50D RID: 42253 RVA: 0x0029009C File Offset: 0x0028E29C
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

		// Token: 0x0600A50E RID: 42254 RVA: 0x002900AC File Offset: 0x0028E2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsRequest()
		{
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x002900BC File Offset: 0x0028E2BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsRequest(AllianceFactsRequest other)
		{
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x002900CC File Offset: 0x0028E2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AllianceFactsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x0600A511 RID: 42257 RVA: 0x002900DC File Offset: 0x0028E2DC
		// (set) Token: 0x0600A512 RID: 42258 RVA: 0x002900EC File Offset: 0x0028E2EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string AllianceUuid
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

		// Token: 0x0600A513 RID: 42259 RVA: 0x002900FC File Offset: 0x0028E2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x0029010C File Offset: 0x0028E30C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(AllianceFactsRequest other)
		{
			return true;
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x0029011C File Offset: 0x0028E31C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x0029012C File Offset: 0x0028E32C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x0029013C File Offset: 0x0028E33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x0029014C File Offset: 0x0028E34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x0029015C File Offset: 0x0028E35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x0029016C File Offset: 0x0028E36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(AllianceFactsRequest other)
		{
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x0029017C File Offset: 0x0028E37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x0029018C File Offset: 0x0028E38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x0029019C File Offset: 0x0028E39C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static AllianceFactsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fdbe83fcafda431197ae585ab85635a6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AllianceFactsRequest._parser = new MessageParser<AllianceFactsRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_763213b47a3444da994f3672f1295fcd != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
					return;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 3;
			}
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x00290280 File Offset: 0x0028E480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool UAqRnxJk2Gc2pGalCvr0()
		{
			return true;
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x00290288 File Offset: 0x0028E488
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static AllianceFactsRequest GI27j2JkE4tTAHBurCXK()
		{
			return null;
		}

		// Token: 0x04003CBC RID: 15548
		private static readonly MessageParser<AllianceFactsRequest> _parser;

		// Token: 0x04003CBD RID: 15549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CBE RID: 15550
		public const int AllianceUuidFieldNumber = 1;

		// Token: 0x04003CBF RID: 15551
		private string allianceUuid_;

		// Token: 0x04003CC0 RID: 15552
		private static AllianceFactsRequest ALDUleJk9cwKqpfTRdOr;
	}
}

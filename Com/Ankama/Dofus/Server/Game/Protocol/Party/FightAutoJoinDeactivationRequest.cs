using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002BA RID: 698
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinDeactivationRequest : IMessage<FightAutoJoinDeactivationRequest>, IMessage, IEquatable<FightAutoJoinDeactivationRequest>, IDeepCloneable<FightAutoJoinDeactivationRequest>, IBufferMessage
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x001BA028 File Offset: 0x001B8228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightAutoJoinDeactivationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x001BA038 File Offset: 0x001B8238
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x001BA048 File Offset: 0x001B8248
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

		// Token: 0x06002078 RID: 8312 RVA: 0x001BA058 File Offset: 0x001B8258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivationRequest()
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x001BA068 File Offset: 0x001B8268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivationRequest(FightAutoJoinDeactivationRequest other)
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x001BA078 File Offset: 0x001B8278
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivationRequest Clone()
		{
			return null;
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x001BA088 File Offset: 0x001B8288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x001BA098 File Offset: 0x001B8298
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinDeactivationRequest other)
		{
			return true;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x001BA0A8 File Offset: 0x001B82A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x001BA0B8 File Offset: 0x001B82B8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x001BA0C8 File Offset: 0x001B82C8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x001BA0D8 File Offset: 0x001B82D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x001BA0E8 File Offset: 0x001B82E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x001BA0F8 File Offset: 0x001B82F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinDeactivationRequest other)
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x001BA108 File Offset: 0x001B8308
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x001BA118 File Offset: 0x001B8318
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x001BA128 File Offset: 0x001B8328
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinDeactivationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f07e3e95855f47e28bdac8b38d04d4a8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 3;
						continue;
					case 3:
						goto IL_9C;
					case 4:
						return;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c5b82ca766c4792853da62b3454c783 != 0)
					{
						num2 = 0;
					}
				}
				IL_9C:
				FightAutoJoinDeactivationRequest._parser = new MessageParser<FightAutoJoinDeactivationRequest>(() => null);
				num = 4;
			}
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x001BA1F8 File Offset: 0x001B83F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool R3lb37O64pwVBJa26mEo()
		{
			return true;
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x001BA200 File Offset: 0x001B8400
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinDeactivationRequest bpTXZJO6jYZWUK94tKZM()
		{
			return null;
		}

		// Token: 0x04000B64 RID: 2916
		private static readonly MessageParser<FightAutoJoinDeactivationRequest> _parser;

		// Token: 0x04000B65 RID: 2917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B66 RID: 2918
		internal static FightAutoJoinDeactivationRequest FIlmsrO6xqqUlFxIH7Ca;
	}
}

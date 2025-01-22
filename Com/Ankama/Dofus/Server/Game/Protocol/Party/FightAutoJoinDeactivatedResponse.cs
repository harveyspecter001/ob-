using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Party
{
	// Token: 0x020002BC RID: 700
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightAutoJoinDeactivatedResponse : IMessage<FightAutoJoinDeactivatedResponse>, IMessage, IEquatable<FightAutoJoinDeactivatedResponse>, IDeepCloneable<FightAutoJoinDeactivatedResponse>, IBufferMessage
	{
		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x001BA208 File Offset: 0x001B8408
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<FightAutoJoinDeactivatedResponse> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x001BA218 File Offset: 0x001B8418
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

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x001BA228 File Offset: 0x001B8428
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

		// Token: 0x06002090 RID: 8336 RVA: 0x001BA238 File Offset: 0x001B8438
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedResponse()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x001BA248 File Offset: 0x001B8448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedResponse(FightAutoJoinDeactivatedResponse other)
		{
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x001BA258 File Offset: 0x001B8458
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FightAutoJoinDeactivatedResponse Clone()
		{
			return null;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x001BA268 File Offset: 0x001B8468
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x001BA27C File Offset: 0x001B847C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public FightAutoJoinDeactivatedResponse.Types.Result Result
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (FightAutoJoinDeactivatedResponse.Types.Result)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x001BA28C File Offset: 0x001B848C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x001BA29C File Offset: 0x001B849C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FightAutoJoinDeactivatedResponse other)
		{
			return true;
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x001BA2AC File Offset: 0x001B84AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x001BA2BC File Offset: 0x001B84BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x001BA2CC File Offset: 0x001B84CC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x001BA2DC File Offset: 0x001B84DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x001BA2EC File Offset: 0x001B84EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x001BA2FC File Offset: 0x001B84FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FightAutoJoinDeactivatedResponse other)
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x001BA30C File Offset: 0x001B850C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x001BA31C File Offset: 0x001B851C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x001BA32C File Offset: 0x001B852C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FightAutoJoinDeactivatedResponse()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FightAutoJoinDeactivatedResponse._parser = new MessageParser<FightAutoJoinDeactivatedResponse>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_08862c9eab7444c19558a8b548142851 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c7f824824f3e461ca678b1189428825f != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x001BA3F8 File Offset: 0x001B85F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool kEbRHvO6IKxBwlIIyKLE()
		{
			return true;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x001BA400 File Offset: 0x001B8600
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FightAutoJoinDeactivatedResponse KEb9yhO6kjJxPpftrCQP()
		{
			return null;
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly MessageParser<FightAutoJoinDeactivatedResponse> _parser;

		// Token: 0x04000B6A RID: 2922
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B6B RID: 2923
		public const int ResultFieldNumber = 1;

		// Token: 0x04000B6C RID: 2924
		private FightAutoJoinDeactivatedResponse.Types.Result result_;

		// Token: 0x04000B6D RID: 2925
		private static FightAutoJoinDeactivatedResponse IO4dWgO6KdR1j6RNgiTy;

		// Token: 0x020002BD RID: 701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060020A2 RID: 8354 RVA: 0x002B4A54 File Offset: 0x002B2C54
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020002BE RID: 702
			public enum Result
			{
				// Token: 0x04000B6F RID: 2927
				[OriginalName("SUCCESS")]
				Success,
				// Token: 0x04000B70 RID: 2928
				[OriginalName("ERROR")]
				Error
			}
		}
	}
}

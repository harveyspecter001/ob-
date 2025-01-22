using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact
{
	// Token: 0x02000840 RID: 2112
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendListRequest : IMessage<FriendListRequest>, IMessage, IEquatable<FriendListRequest>, IDeepCloneable<FriendListRequest>, IBufferMessage
	{
		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x0022BFA0 File Offset: 0x0022A1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendListRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x060066A5 RID: 26277 RVA: 0x0022BFB0 File Offset: 0x0022A1B0
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

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x0022BFC0 File Offset: 0x0022A1C0
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

		// Token: 0x060066A7 RID: 26279 RVA: 0x0022BFD0 File Offset: 0x0022A1D0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest()
		{
		}

		// Token: 0x060066A8 RID: 26280 RVA: 0x0022BFE0 File Offset: 0x0022A1E0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest(FriendListRequest other)
		{
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x0022BFF0 File Offset: 0x0022A1F0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendListRequest Clone()
		{
			return null;
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x0022C000 File Offset: 0x0022A200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x0022C010 File Offset: 0x0022A210
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(FriendListRequest other)
		{
			return true;
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x0022C020 File Offset: 0x0022A220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x0022C030 File Offset: 0x0022A230
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060066AE RID: 26286 RVA: 0x0022C040 File Offset: 0x0022A240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060066AF RID: 26287 RVA: 0x0022C050 File Offset: 0x0022A250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060066B0 RID: 26288 RVA: 0x0022C060 File Offset: 0x0022A260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060066B1 RID: 26289 RVA: 0x0022C070 File Offset: 0x0022A270
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(FriendListRequest other)
		{
		}

		// Token: 0x060066B2 RID: 26290 RVA: 0x0022C080 File Offset: 0x0022A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060066B3 RID: 26291 RVA: 0x0022C090 File Offset: 0x0022A290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060066B4 RID: 26292 RVA: 0x0022C0A0 File Offset: 0x0022A2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static FriendListRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8c299f020fb547e49c451f49740c5d16 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				FriendListRequest._parser = new MessageParser<FriendListRequest>(() => null);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_8793adccb59548138145e36aa64d0b4b == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x0022C184 File Offset: 0x0022A384
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Q9ACcPJfbBpuV8to7H2g()
		{
			return true;
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x0022C18C File Offset: 0x0022A38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static FriendListRequest J0SU1FJfi3qo2dWa8fE3()
		{
			return null;
		}

		// Token: 0x04002403 RID: 9219
		private static readonly MessageParser<FriendListRequest> _parser;

		// Token: 0x04002404 RID: 9220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002405 RID: 9221
		internal static FriendListRequest CdcDZtJfYinH0ChC4ghR;
	}
}

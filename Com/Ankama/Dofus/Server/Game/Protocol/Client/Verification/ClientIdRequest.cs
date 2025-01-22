using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification
{
	// Token: 0x020008AC RID: 2220
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClientIdRequest : IMessage<ClientIdRequest>, IMessage, IEquatable<ClientIdRequest>, IDeepCloneable<ClientIdRequest>, IBufferMessage
	{
		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x00231C50 File Offset: 0x0022FE50
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ClientIdRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x00231C60 File Offset: 0x0022FE60
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

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x00231C70 File Offset: 0x0022FE70
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

		// Token: 0x06006BD5 RID: 27605 RVA: 0x00231C80 File Offset: 0x0022FE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientIdRequest()
		{
		}

		// Token: 0x06006BD6 RID: 27606 RVA: 0x00231C90 File Offset: 0x0022FE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientIdRequest(ClientIdRequest other)
		{
		}

		// Token: 0x06006BD7 RID: 27607 RVA: 0x00231CA0 File Offset: 0x0022FEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClientIdRequest Clone()
		{
			return null;
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x00231CB0 File Offset: 0x0022FEB0
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x00231CC0 File Offset: 0x0022FEC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public string Id
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

		// Token: 0x06006BDA RID: 27610 RVA: 0x00231CD0 File Offset: 0x0022FED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00231CE0 File Offset: 0x0022FEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ClientIdRequest other)
		{
			return true;
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00231CF0 File Offset: 0x0022FEF0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00231D00 File Offset: 0x0022FF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00231D10 File Offset: 0x0022FF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00231D20 File Offset: 0x0022FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x00231D30 File Offset: 0x0022FF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00231D40 File Offset: 0x0022FF40
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ClientIdRequest other)
		{
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x00231D50 File Offset: 0x0022FF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x00231D60 File Offset: 0x0022FF60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x00231D70 File Offset: 0x0022FF70
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ClientIdRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ClientIdRequest._parser = new MessageParser<ClientIdRequest>(() => null);
					num2 = 2;
					continue;
				case 2:
					return;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3b820d51a0304d6b80583bcd6b858510 != 0)
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
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x00231E3C File Offset: 0x0023003C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool i8hSFxJmTNldvL3ZBGdi()
		{
			return true;
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x00231E44 File Offset: 0x00230044
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ClientIdRequest BWOLd9JmpNejogJfrhIw()
		{
			return null;
		}

		// Token: 0x040025A7 RID: 9639
		private static readonly MessageParser<ClientIdRequest> _parser;

		// Token: 0x040025A8 RID: 9640
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025A9 RID: 9641
		public const int IdFieldNumber = 1;

		// Token: 0x040025AA RID: 9642
		private string id_;

		// Token: 0x040025AB RID: 9643
		internal static ClientIdRequest bOs41eJm7uP0xXEhLD8v;
	}
}
